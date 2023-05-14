using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Newtonsoft.Json;

namespace KranumCore.ViewResource.Test
{
    public class FullNameViewResource: ITestViewResource
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get; set; }
    }
    public class FullNameWihEmailIdViewResource: ITestViewResource
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
    }

    public class EmailIdViewResource: ITestViewResource
    {
        public string EmailId { get; set; }
    }

    public class PersonViewResource: ITestViewResource
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
    }

    public interface ITestViewResource
    {

    }



    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
    }

    public class TestFactory
    {
        private readonly Person _person;
        private readonly IMapper _mapper;
        public TestFactory(IMapper mapper)
        {
            _mapper = mapper;
            _person = new Person()
            {
                FirstName = "Vishal",
                LastName = "Mantri",
                EmailId = "mantriv@hotmail.com",
                Address = "Sarjapura Road",
                City = "Bangalore",
                Phone = "9845139787"
            };
        }
        public ITestViewResource Get(string param)
        {
            if (param == "All")
            {
                var result = _mapper.Map<PersonViewResource>(_person);
                return result;
            }
            else if (param == "FullName")
            {
                var result = _mapper.Map<FullNameViewResource>(_person);
                return result;
            }
            else if (param == "FullNameWithEmailId")
            {
                var result = _mapper.Map<FullNameWihEmailIdViewResource>(_person);
                return result;
            }
            else
            {
                var result = _mapper.Map<EmailIdViewResource>(_person);
                return result;
            }
        }
    }
}
