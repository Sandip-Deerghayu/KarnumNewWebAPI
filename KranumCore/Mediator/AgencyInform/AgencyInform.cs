using AutoMapper;
using KranumCore.BlobHandler;
using KranumCore.ExceptionHandler;
using KranumCore.ViewResource.AgencyInorm;
using KranumCore.ViewResource.User;
using KranumDataAccess.Models;
using KranumDataAccess.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using KranumCore.ViewResource.Error;
using System.Net;
using Newtonsoft.Json.Linq;
using KranumCore.ViewResource.UserNotes;

namespace KranumCore.Mediator.AgencyInform
{
    public class AgencyInform
    {
        public class Command : IRequest<AgencyInormResponseViewResource>
        {
            public CreateAgencyUserRequestViewResource CreateAgencyUserRequestViewResource { get; set; }


        }

        public class Handler : IRequestHandler<Command, AgencyInormResponseViewResource>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            private readonly IConfiguration _configuration;
            private readonly IBlobManager _blobManager;
            private readonly RelyfyDotNetStagingContext _dbContext;
            public Encoding Encoding { get; set; } = Encoding.UTF8;

            public Handler(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration, IBlobManager blobManager, RelyfyDotNetStagingContext dbContext)
            {
                _mapper = mapper;
                _unitOfWork = unitOfWork;
                _configuration = configuration;
                _blobManager = blobManager;
                _dbContext = dbContext;
            }

            public async Task<AgencyInormResponseViewResource> Handle(Command request, CancellationToken cancellationToken)
            {
                HttpResponseMessage responseRegisterAPI = new HttpResponseMessage();
                HttpResponseMessage responseLoginAPI = new HttpResponseMessage();
                HttpResponseMessage responseBusinessRegistrationAPI = new HttpResponseMessage();
                var loginResponseViewResource = new ViewResource.AgencyInorm.LoginResponseViewResource();
                var errorResponse = new ErrorResponse();
                var response = new AgencyInormResponseViewResource();


                try
                {
                    var url = _configuration.GetValue<string>("wizkindUrl");

                    var registerUrl = url + "UserLogin/addUserRegistration";
                    var registerUrlLoginAPI = url + "UserLogin/verifyUserCredential";
                    var registerBussinessUrl = url + "UserLogin/addUserBusinessProfile";

                    /* User Registration */
                    using (var httpClient = new HttpClient())
                    {
                        responseRegisterAPI = await httpClient.PostAsJsonAsync(
                        registerUrl, request.CreateAgencyUserRequestViewResource);
                        var dataResponse = await responseRegisterAPI.Content.ReadAsByteArrayAsync();
                        var responseRegisterData = await System.Threading.Tasks.Task.Run(() => JsonConvert.DeserializeObject(Encoding.GetString(dataResponse)));
                    }


                    /* Login API call successfully after business register call api */

                    if (responseRegisterAPI != null && responseRegisterAPI.IsSuccessStatusCode == true)
                    {
                        var loginRequset = new AgencyUserLoginRequestViewResource();
                        using (var httpClient = new HttpClient())
                        {
                            loginRequset.emailId = request.CreateAgencyUserRequestViewResource.emailId;
                            loginRequset.password = request.CreateAgencyUserRequestViewResource.password;
                            responseLoginAPI = await httpClient.PostAsJsonAsync(
                             registerUrlLoginAPI, loginRequset);
                            var dataResponse = await responseLoginAPI.Content.ReadAsByteArrayAsync();
                            loginResponseViewResource = await System.Threading.Tasks.Task.Run(() => JsonConvert.DeserializeObject<ViewResource.AgencyInorm.LoginResponseViewResource>(Encoding.GetString(dataResponse)));
                        }

                        var clientContact = new ClientContactPerson();
                        /* Write code for the business registration */

                        if (responseLoginAPI != null && responseLoginAPI.IsSuccessStatusCode == true)
                        {
                            var bussinesRequset = new CreateAgencyBusinessRegistrationRequestViewResource();
                            var agenciesDetails = new AgenciesDetails();
                            using (var httpClient = new HttpClient())
                            {
                                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", loginResponseViewResource.token);
                                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));



                                bussinesRequset.id = loginResponseViewResource.id;
                                bussinesRequset.mobileNumber = loginResponseViewResource.mobileNumber;
                                bussinesRequset.agency = true;
                                bussinesRequset.agenciesDetails = loginResponseViewResource.agenciesDetails;
                                var agence = _dbContext.ClientContactPerson.Where(x => x.EmailId == loginResponseViewResource.emailId).SingleOrDefault();

                                agenciesDetails.firstName = loginResponseViewResource.firstName;
                                agenciesDetails.lastName = loginResponseViewResource.lastName;
                                agenciesDetails.mobileNumber = loginResponseViewResource.mobileNumber;
                                bussinesRequset.emailId = agenciesDetails.emailId = loginResponseViewResource.emailId;
                                if (agence != null)
                                {
                                    agenciesDetails.addressLine = agence.AddressLine;
                                    agenciesDetails.address = agence.Address;
                                    agenciesDetails.companyName = agence.CompanyName;
                                    agenciesDetails.city = agence.City;
                                    agenciesDetails.emailId = agence.EmailId;
                                    agenciesDetails.state = agence.State;
                                    agenciesDetails.zip = agence.Zip;
                                    agenciesDetails.country = agence.Country;
                                }
                                bussinesRequset.agenciesDetails = agenciesDetails;

                                string content = await System.Threading.Tasks.Task.Run(() => JsonConvert.SerializeObject(bussinesRequset));

                                responseBusinessRegistrationAPI = await httpClient.PostAsync(registerBussinessUrl, new StringContent(content, Encoding.UTF8, "application/json"));

                                if (responseBusinessRegistrationAPI != null && responseBusinessRegistrationAPI.IsSuccessStatusCode == true)
                                {
                                    var dataResponse1 = await responseBusinessRegistrationAPI.Content.ReadAsByteArrayAsync();
                                    var bussnessresponse = await System.Threading.Tasks.Task.Run(() => JsonConvert.DeserializeObject(Encoding.GetString(dataResponse1)));

                                    JToken ObjectBusiness = JObject.FromObject(bussnessresponse);
                                    var id = (int)ObjectBusiness["object"]["id"];
                                    /* successfully register after data update in ClientContactPerson */
                                    if (agence != null)
                                    {
                                        clientContact = agence;
                                        clientContact.CityId = agence.CityId;
                                        clientContact.EmailId = agence.EmailId;
                                        clientContact.CompanyName = agence.CompanyName;
                                        clientContact.Address = agence.Address;
                                        clientContact.AddressLine = agence.AddressLine;
                                        clientContact.City = agence.City;
                                        clientContact.Country = agence.Country;
                                        clientContact.State = agence.State;
                                        clientContact.LastName = loginResponseViewResource.lastName;
                                        clientContact.Name = loginResponseViewResource.firstName;
                                        clientContact.ContactNo = loginResponseViewResource.mobileNumber;
                                        clientContact.EmailId = loginResponseViewResource.emailId;
                                        clientContact.IsWizkindConnected = true;
                                        clientContact.WizkindAgencyId = id;
                                        clientContact.WizkindSecret = EncodePasswordToBase64(request.CreateAgencyUserRequestViewResource.password);
                                        var entity = await _unitOfWork.GetClientContactPersonRepository().UpdateAsync(clientContact);
                                        response = _mapper.Map<AgencyInormResponseViewResource>(entity);
                                    }
                                    _unitOfWork.SaveChanges();
                                }
                            }
                        }
                    }
                    else
                    {
                        errorResponse.DataValidationErrors.Add("User already exist!");
                        if (errorResponse.DataValidationErrors.Any())
                        {
                            throw new RestException(HttpStatusCode.BadRequest, new { error = "Events not found!" });
                        }
                    }

                    return response;
                }
                catch (Exception ex)
                {
                    switch (ex)
                    {
                        case RestException rex:
                            throw rex;
                    }

                    throw new Exception("Error while register user", ex);
                }

            }





            public string EncodePasswordToBase64(string password)
            {
                try
                {
                    byte[] encData_byte = new byte[password.Length];
                    encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                    string encodedData = Convert.ToBase64String(encData_byte);
                    return encodedData;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in base64Encode" + ex.Message);
                }
            }
            //this function Convert to Decord your Password
            public string DecodeFrom64(string encodedData)
            {
                System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                System.Text.Decoder utf8Decode = encoder.GetDecoder();
                byte[] todecode_byte = Convert.FromBase64String(encodedData);
                int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
                char[] decoded_char = new char[charCount];
                utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                string result = new String(decoded_char);
                return result;
            }
        }

    }
}
