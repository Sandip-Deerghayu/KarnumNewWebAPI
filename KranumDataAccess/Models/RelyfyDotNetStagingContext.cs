using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class RelyfyDotNetStagingContext : DbContext
    {
        public RelyfyDotNetStagingContext()
        {
        }

        public RelyfyDotNetStagingContext(DbContextOptions<RelyfyDotNetStagingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbnormalTypeForMindSituationForReadingSpecificsForPulse> AbnormalTypeForMindSituationForReadingSpecificsForPulse { get; set; }
        public virtual DbSet<AbnormalTypeForMindSituationForReadingSpecificsForRespirations> AbnormalTypeForMindSituationForReadingSpecificsForRespirations { get; set; }
        public virtual DbSet<AbnormalTypeForSituationForReadingSpecificsForTemperature> AbnormalTypeForSituationForReadingSpecificsForTemperature { get; set; }
        public virtual DbSet<AbnormalityTypeForAppendageForCareClientPulseOxygenInformation> AbnormalityTypeForAppendageForCareClientPulseOxygenInformation { get; set; }
        public virtual DbSet<ActivityPain> ActivityPain { get; set; }
        public virtual DbSet<AdlQuestionMapping> AdlQuestionMapping { get; set; }
        public virtual DbSet<AgencyFormBuilder> AgencyFormBuilder { get; set; }
        public virtual DbSet<AgencyHolidayCallTypeMapping> AgencyHolidayCallTypeMapping { get; set; }
        public virtual DbSet<AgencyHolidayRates> AgencyHolidayRates { get; set; }
        public virtual DbSet<AgencyHolidays> AgencyHolidays { get; set; }
        public virtual DbSet<AgencyInteraction> AgencyInteraction { get; set; }
        public virtual DbSet<AgencyInteractionMapping> AgencyInteractionMapping { get; set; }
        public virtual DbSet<AgencyLocations> AgencyLocations { get; set; }
        public virtual DbSet<AgencyMilesRate> AgencyMilesRate { get; set; }
        public virtual DbSet<AgencyMilesRateWithCallType> AgencyMilesRateWithCallType { get; set; }
        public virtual DbSet<AgencyOnCallInformation> AgencyOnCallInformation { get; set; }
        public virtual DbSet<AgencyOnCallInformationMappingLocation> AgencyOnCallInformationMappingLocation { get; set; }
        public virtual DbSet<AgencyOverTimeRule> AgencyOverTimeRule { get; set; }
        public virtual DbSet<AgencyPaymentEmailId> AgencyPaymentEmailId { get; set; }
        public virtual DbSet<AgencyPlanDetail> AgencyPlanDetail { get; set; }
        public virtual DbSet<AgencyRecurrence> AgencyRecurrence { get; set; }
        public virtual DbSet<AgencyRoidata> AgencyRoidata { get; set; }
        public virtual DbSet<AgencySettings> AgencySettings { get; set; }
        public virtual DbSet<AideHousekeepingTaskScheduleMappingCareClientTaskInformationForEnvironment> AideHousekeepingTaskScheduleMappingCareClientTaskInformationForEnvironment { get; set; }
        public virtual DbSet<AideLaundaryTaskScheduleMappingCareClientTaskInformationForEnvironment> AideLaundaryTaskScheduleMappingCareClientTaskInformationForEnvironment { get; set; }
        public virtual DbSet<AideNameListForSatisfactionOfSupervisory> AideNameListForSatisfactionOfSupervisory { get; set; }
        public virtual DbSet<AideNameMappingSatisfactionInformation> AideNameMappingSatisfactionInformation { get; set; }
        public virtual DbSet<Alerts> Alerts { get; set; }
        public virtual DbSet<AlertsAssessmentDates> AlertsAssessmentDates { get; set; }
        public virtual DbSet<AmbulationEmployeeEvalutionInformatiom> AmbulationEmployeeEvalutionInformatiom { get; set; }
        public virtual DbSet<AndroidAppVersionForCarehub> AndroidAppVersionForCarehub { get; set; }
        public virtual DbSet<AndroidAppVersionForRegruit> AndroidAppVersionForRegruit { get; set; }
        public virtual DbSet<AndroidAppVersions> AndroidAppVersions { get; set; }
        public virtual DbSet<AndroidAppVersionsForRelyfyNotes> AndroidAppVersionsForRelyfyNotes { get; set; }
        public virtual DbSet<AppendageTypeForReadingSpecificsForPulseOxygen> AppendageTypeForReadingSpecificsForPulseOxygen { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUser { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<AppointmentActivity> AppointmentActivity { get; set; }
        public virtual DbSet<AppointmentConfirmation> AppointmentConfirmation { get; set; }
        public virtual DbSet<AppointmentMedicationMapping> AppointmentMedicationMapping { get; set; }
        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<AppointmentsNurseApproval> AppointmentsNurseApproval { get; set; }
        public virtual DbSet<AppointmentsRequest> AppointmentsRequest { get; set; }
        public virtual DbSet<AssessorPayrollTerms> AssessorPayrollTerms { get; set; }
        public virtual DbSet<AssessorScreenList> AssessorScreenList { get; set; }
        public virtual DbSet<AssessorScreenMappingLevel> AssessorScreenMappingLevel { get; set; }
        public virtual DbSet<AssessorScrrenListMappingMandatoryQues> AssessorScrrenListMappingMandatoryQues { get; set; }
        public virtual DbSet<AssignForms> AssignForms { get; set; }
        public virtual DbSet<BenefitLinksForApp> BenefitLinksForApp { get; set; }
        public virtual DbSet<BillPayRateChangeLog> BillPayRateChangeLog { get; set; }
        public virtual DbSet<BodyTemperatureWaysForReadingSpecificsForTemperature> BodyTemperatureWaysForReadingSpecificsForTemperature { get; set; }
        public virtual DbSet<BusinessContactCounty> BusinessContactCounty { get; set; }
        public virtual DbSet<BusinessContactInformation> BusinessContactInformation { get; set; }
        public virtual DbSet<BusinessContactInformationCopy> BusinessContactInformationCopy { get; set; }
        public virtual DbSet<BusinessContactInformationLatestCanary> BusinessContactInformationLatestCanary { get; set; }
        public virtual DbSet<BusinessContactMappingFbPost> BusinessContactMappingFbPost { get; set; }
        public virtual DbSet<BusinessContactMappingFbPostLatestCanary> BusinessContactMappingFbPostLatestCanary { get; set; }
        public virtual DbSet<BusinessContactMappingService> BusinessContactMappingService { get; set; }
        public virtual DbSet<BusinessContactMappingServiceLatestCanary> BusinessContactMappingServiceLatestCanary { get; set; }
        public virtual DbSet<BusinessContactMappingTag> BusinessContactMappingTag { get; set; }
        public virtual DbSet<BusinessContactMappingTagLatestCanary> BusinessContactMappingTagLatestCanary { get; set; }
        public virtual DbSet<BusinessContactMappingWebsiteText> BusinessContactMappingWebsiteText { get; set; }
        public virtual DbSet<BusinessContactMappingWebsiteTextLatestCanary> BusinessContactMappingWebsiteTextLatestCanary { get; set; }
        public virtual DbSet<BusinessIndeedJobData> BusinessIndeedJobData { get; set; }
        public virtual DbSet<BusinessInteraction> BusinessInteraction { get; set; }
        public virtual DbSet<BusinessLabelList> BusinessLabelList { get; set; }
        public virtual DbSet<BusinessMailInteraction> BusinessMailInteraction { get; set; }
        public virtual DbSet<BusinessMappingCountyServed> BusinessMappingCountyServed { get; set; }
        public virtual DbSet<BusinessMappingLabel> BusinessMappingLabel { get; set; }
        public virtual DbSet<BusinessMappingStateServed> BusinessMappingStateServed { get; set; }
        public virtual DbSet<BusinessOtherContact> BusinessOtherContact { get; set; }
        public virtual DbSet<BusinessOtherContactLatestCanary> BusinessOtherContactLatestCanary { get; set; }
        public virtual DbSet<BusinessScoringCriteria> BusinessScoringCriteria { get; set; }
        public virtual DbSet<BusinessServiceTags> BusinessServiceTags { get; set; }
        public virtual DbSet<CallType> CallType { get; set; }
        public virtual DbSet<CancelAppointments> CancelAppointments { get; set; }
        public virtual DbSet<CareBusinessForumLeads> CareBusinessForumLeads { get; set; }
        public virtual DbSet<CareBusinessForumQuestionList> CareBusinessForumQuestionList { get; set; }
        public virtual DbSet<CareBusinessForumQuestionMappingAnswer> CareBusinessForumQuestionMappingAnswer { get; set; }
        public virtual DbSet<CareBusinessForumQuestionMappingOption> CareBusinessForumQuestionMappingOption { get; set; }
        public virtual DbSet<CareBusinessForumQuestionMappingOptionCopy> CareBusinessForumQuestionMappingOptionCopy { get; set; }
        public virtual DbSet<CareBusinessForumQuestionMappingSubOption> CareBusinessForumQuestionMappingSubOption { get; set; }
        public virtual DbSet<CareBusinessForumUpdatedInfo> CareBusinessForumUpdatedInfo { get; set; }
        public virtual DbSet<CareClientAdvanceDirectiveInformation> CareClientAdvanceDirectiveInformation { get; set; }
        public virtual DbSet<CareClientAdvanceDirectiveMappingDocument> CareClientAdvanceDirectiveMappingDocument { get; set; }
        public virtual DbSet<CareClientAllergyInformation> CareClientAllergyInformation { get; set; }
        public virtual DbSet<CareClientAllergyMappingQue> CareClientAllergyMappingQue { get; set; }
        public virtual DbSet<CareClientAndNurseSignature> CareClientAndNurseSignature { get; set; }
        public virtual DbSet<CareClientAppearance> CareClientAppearance { get; set; }
        public virtual DbSet<CareClientAttchments> CareClientAttchments { get; set; }
        public virtual DbSet<CareClientBloodPressureInformation> CareClientBloodPressureInformation { get; set; }
        public virtual DbSet<CareClientBloodPressureMappingAbnormality> CareClientBloodPressureMappingAbnormality { get; set; }
        public virtual DbSet<CareClientCardiovascularInformation> CareClientCardiovascularInformation { get; set; }
        public virtual DbSet<CareClientCardiovascularInformationMappingHeartSound> CareClientCardiovascularInformationMappingHeartSound { get; set; }
        public virtual DbSet<CareClientCardiovascularInformationMappingLimitation> CareClientCardiovascularInformationMappingLimitation { get; set; }
        public virtual DbSet<CareClientCardiovascularInformationMappingShortnessOfBreathWithActivity> CareClientCardiovascularInformationMappingShortnessOfBreathWithActivity { get; set; }
        public virtual DbSet<CareClientCardiovascularInformationMappingShortnessOfBreathWithoutActivity> CareClientCardiovascularInformationMappingShortnessOfBreathWithoutActivity { get; set; }
        public virtual DbSet<CareClientCarePlan> CareClientCarePlan { get; set; }
        public virtual DbSet<CareClientConnectLogin> CareClientConnectLogin { get; set; }
        public virtual DbSet<CareClientContactInformation> CareClientContactInformation { get; set; }
        public virtual DbSet<CareClientContactInformationCopy> CareClientContactInformationCopy { get; set; }
        public virtual DbSet<CareClientContactInformationOld> CareClientContactInformationOld { get; set; }
        public virtual DbSet<CareClientDiagnosis> CareClientDiagnosis { get; set; }
        public virtual DbSet<CareClientDiagnosisMappig> CareClientDiagnosisMappig { get; set; }
        public virtual DbSet<CareClientDiegestionMouthInformationMappingLimitation> CareClientDiegestionMouthInformationMappingLimitation { get; set; }
        public virtual DbSet<CareClientDigestionGastrointestinalInformation> CareClientDigestionGastrointestinalInformation { get; set; }
        public virtual DbSet<CareClientDigestionGastrointestinalInformationMappingLimitation> CareClientDigestionGastrointestinalInformationMappingLimitation { get; set; }
        public virtual DbSet<CareClientDigestionGenitourinaryBladderIncontinenceLimitation> CareClientDigestionGenitourinaryBladderIncontinenceLimitation { get; set; }
        public virtual DbSet<CareClientDigestionGenitourinaryInformation> CareClientDigestionGenitourinaryInformation { get; set; }
        public virtual DbSet<CareClientDigestionGenitourinaryInformationMappingLimitation> CareClientDigestionGenitourinaryInformationMappingLimitation { get; set; }
        public virtual DbSet<CareClientDigestionMouthDenturesLimitation> CareClientDigestionMouthDenturesLimitation { get; set; }
        public virtual DbSet<CareClientDigestionMouthInformation> CareClientDigestionMouthInformation { get; set; }
        public virtual DbSet<CareClientDisasterInformation> CareClientDisasterInformation { get; set; }
        public virtual DbSet<CareClientDischargeInformation> CareClientDischargeInformation { get; set; }
        public virtual DbSet<CareClientEarsInformation> CareClientEarsInformation { get; set; }
        public virtual DbSet<CareClientEarsInformationMappingLimitation> CareClientEarsInformationMappingLimitation { get; set; }
        public virtual DbSet<CareClientEventsInformation> CareClientEventsInformation { get; set; }
        public virtual DbSet<CareClientEyesInformaion> CareClientEyesInformaion { get; set; }
        public virtual DbSet<CareClientEyesInformationMappingEyesLimitations> CareClientEyesInformationMappingEyesLimitations { get; set; }
        public virtual DbSet<CareClientGeneralPainInformation> CareClientGeneralPainInformation { get; set; }
        public virtual DbSet<CareClientGlucoseInformation> CareClientGlucoseInformation { get; set; }
        public virtual DbSet<CareClientGlucoseInformationMappingTestingPerformBy> CareClientGlucoseInformationMappingTestingPerformBy { get; set; }
        public virtual DbSet<CareClientGlucoseMappingGlucoseManagedBy> CareClientGlucoseMappingGlucoseManagedBy { get; set; }
        public virtual DbSet<CareClientGoalsInformation> CareClientGoalsInformation { get; set; }
        public virtual DbSet<CareClientGoalsInformationMappingPhotos> CareClientGoalsInformationMappingPhotos { get; set; }
        public virtual DbSet<CareClientHeadNeckInformation> CareClientHeadNeckInformation { get; set; }
        public virtual DbSet<CareClientHeadNeckInformationMappingLimitation> CareClientHeadNeckInformationMappingLimitation { get; set; }
        public virtual DbSet<CareClientHolidayStatus> CareClientHolidayStatus { get; set; }
        public virtual DbSet<CareClientImportantInformation> CareClientImportantInformation { get; set; }
        public virtual DbSet<CareClientInformationForPolici> CareClientInformationForPolici { get; set; }
        public virtual DbSet<CareClientInformationForPoliciesMappingPoliciesForConsents> CareClientInformationForPoliciesMappingPoliciesForConsents { get; set; }
        public virtual DbSet<CareClientInteractionDetails> CareClientInteractionDetails { get; set; }
        public virtual DbSet<CareClientMappingService> CareClientMappingService { get; set; }
        public virtual DbSet<CaryfySupportEmail> CaryfySupportEmail { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ClientContactPerson> ClientContactPerson { get; set; }
        public virtual DbSet<ClientContactPersonCopy> ClientContactPersonCopy { get; set; }
        public virtual DbSet<ClientLocations> ClientLocations { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<CustomerContactMappingTag> CustomerContactMappingTag { get; set; }
        public virtual DbSet<CustomerInteraction> CustomerInteraction { get; set; }
        public virtual DbSet<CustomerMailInteraction> CustomerMailInteraction { get; set; }
        public virtual DbSet<DashBoardManagement> DashBoardManagement { get; set; }
        public virtual DbSet<DataScrapAgency> DataScrapAgency { get; set; }
        public virtual DbSet<DataScrapeProcess> DataScrapeProcess { get; set; }
        public virtual DbSet<DossierRequest> DossierRequest { get; set; }
        public virtual DbSet<DossierRequestMappingNextlinkEmail> DossierRequestMappingNextlinkEmail { get; set; }
        public virtual DbSet<EmailAnalystFromExcel> EmailAnalystFromExcel { get; set; }
        public virtual DbSet<EmailCampaignMappingTemplate> EmailCampaignMappingTemplate { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplate { get; set; }
        public virtual DbSet<EmployeeAvailability> EmployeeAvailability { get; set; }
        public virtual DbSet<EmployeeBusinessAccess> EmployeeBusinessAccess { get; set; }
        public virtual DbSet<EmployeeBusinessAccessMappingCounty> EmployeeBusinessAccessMappingCounty { get; set; }
        public virtual DbSet<EmployeeBusinessAccessMappingProduct> EmployeeBusinessAccessMappingProduct { get; set; }
        public virtual DbSet<EmployeeBusinessAccessMappingService> EmployeeBusinessAccessMappingService { get; set; }
        public virtual DbSet<EmployeeBusinessAccessMappingState> EmployeeBusinessAccessMappingState { get; set; }
        public virtual DbSet<EmployeeFavouriteItem> EmployeeFavouriteItem { get; set; }
        public virtual DbSet<EmployeeFavouriteItemLog> EmployeeFavouriteItemLog { get; set; }
        public virtual DbSet<EmployeeOtherContact> EmployeeOtherContact { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<EmpoyeeFeatureMapping> EmpoyeeFeatureMapping { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<EventEmailSent> EventEmailSent { get; set; }
        public virtual DbSet<EventKindBusinessData> EventKindBusinessData { get; set; }
        public virtual DbSet<EventKindUserDetail> EventKindUserDetail { get; set; }
        public virtual DbSet<EventKindUserLoggedInDetails> EventKindUserLoggedInDetails { get; set; }
        public virtual DbSet<EventOrganizer> EventOrganizer { get; set; }
        public virtual DbSet<EventParticipant> EventParticipant { get; set; }
        public virtual DbSet<EvvinfoMappingState> EvvinfoMappingState { get; set; }
        public virtual DbSet<FeatureEmployeeMapping> FeatureEmployeeMapping { get; set; }
        public virtual DbSet<FeatureRoleMappings> FeatureRoleMappings { get; set; }
        public virtual DbSet<Features> Features { get; set; }
        public virtual DbSet<FirstDemoInteraction> FirstDemoInteraction { get; set; }
        public virtual DbSet<FirstDemoInteractionMappingKeyObjective> FirstDemoInteractionMappingKeyObjective { get; set; }
        public virtual DbSet<FirstDemoQuestion> FirstDemoQuestion { get; set; }
        public virtual DbSet<FirstDemoQuestionMappingAnswer> FirstDemoQuestionMappingAnswer { get; set; }
        public virtual DbSet<FirstDemoQuestionMappingPayer> FirstDemoQuestionMappingPayer { get; set; }
        public virtual DbSet<FirstDemoQuestionMappingPriorityAnswer> FirstDemoQuestionMappingPriorityAnswer { get; set; }
        public virtual DbSet<Franchise> Franchise { get; set; }
        public virtual DbSet<FranchiseNameList> FranchiseNameList { get; set; }
        public virtual DbSet<FromEmailForTemplate> FromEmailForTemplate { get; set; }
        public virtual DbSet<IgnoreTextList> IgnoreTextList { get; set; }
        public virtual DbSet<ImportBusinessData> ImportBusinessData { get; set; }
        public virtual DbSet<ImportBusinessFbPosts> ImportBusinessFbPosts { get; set; }
        public virtual DbSet<ImportWebSiteText> ImportWebSiteText { get; set; }
        public virtual DbSet<IndeedJobCompanyMappingBusiness> IndeedJobCompanyMappingBusiness { get; set; }
        public virtual DbSet<JwtokenVeraMedix> JwtokenVeraMedix { get; set; }
        public virtual DbSet<Jwttoken> Jwttoken { get; set; }
        public virtual DbSet<NewBusinessFburl> NewBusinessFburl { get; set; }
        public virtual DbSet<NonFranchise> NonFranchise { get; set; }
        public virtual DbSet<Package> Package { get; set; }
        public virtual DbSet<PlayerVideo> PlayerVideo { get; set; }
        public virtual DbSet<PlayerVideoQuestion> PlayerVideoQuestion { get; set; }
        public virtual DbSet<PlayerVideoQuizCongratulationStatus> PlayerVideoQuizCongratulationStatus { get; set; }
        public virtual DbSet<PlayerVideoUserDetails> PlayerVideoUserDetails { get; set; }
        public virtual DbSet<PlayerVideoUserEvents> PlayerVideoUserEvents { get; set; }
        public virtual DbSet<PlayerVideoUserQuestionAnswer> PlayerVideoUserQuestionAnswer { get; set; }
        public virtual DbSet<ProspactNewContact> ProspactNewContact { get; set; }
        public virtual DbSet<ProspactNewContact1> ProspactNewContact1 { get; set; }
        public virtual DbSet<ProspactNewContactMappingService> ProspactNewContactMappingService { get; set; }
        public virtual DbSet<ProspactNewContactMappingService1> ProspactNewContactMappingService1 { get; set; }
        public virtual DbSet<ProspactNewContactServices> ProspactNewContactServices { get; set; }
        public virtual DbSet<ProspectContactMappingTag> ProspectContactMappingTag { get; set; }
        public virtual DbSet<ProspectDemoRequest> ProspectDemoRequest { get; set; }
        public virtual DbSet<ProspectDemoRequestMappingAnswer> ProspectDemoRequestMappingAnswer { get; set; }
        public virtual DbSet<ProspectDemoRequestMappingPriorityAnswer> ProspectDemoRequestMappingPriorityAnswer { get; set; }
        public virtual DbSet<ProspectInteraction> ProspectInteraction { get; set; }
        public virtual DbSet<ProspectInteractionCopy> ProspectInteractionCopy { get; set; }
        public virtual DbSet<ProspectMailInteraction> ProspectMailInteraction { get; set; }
        public virtual DbSet<ProspectMailInteractionCopy> ProspectMailInteractionCopy { get; set; }
        public virtual DbSet<ProspectOtherContact> ProspectOtherContact { get; set; }
        public virtual DbSet<ProspectStatusHistory> ProspectStatusHistory { get; set; }
        public virtual DbSet<ProspectView> ProspectView { get; set; }
        public virtual DbSet<ReferralCompany> ReferralCompany { get; set; }
        public virtual DbSet<ReferralCompanyCaryFyDocument> ReferralCompanyCaryFyDocument { get; set; }
        public virtual DbSet<ReferralCompanyCaryFyDocumentMappingUrl> ReferralCompanyCaryFyDocumentMappingUrl { get; set; }
        public virtual DbSet<ReferralSource> ReferralSource { get; set; }
        public virtual DbSet<RelyFyAgencyAdvanceBilling> RelyFyAgencyAdvanceBilling { get; set; }
        public virtual DbSet<RelyFyAgencyInvoiceBilling> RelyFyAgencyInvoiceBilling { get; set; }
        public virtual DbSet<RelyFyAgencyInvoiceBillingFormula> RelyFyAgencyInvoiceBillingFormula { get; set; }
        public virtual DbSet<RelyFyAgencyInvoiceBillingMailSent> RelyFyAgencyInvoiceBillingMailSent { get; set; }
        public virtual DbSet<RelyFyAgencyInvoicePayment> RelyFyAgencyInvoicePayment { get; set; }
        public virtual DbSet<RelyFyFeedbackResponse> RelyFyFeedbackResponse { get; set; }
        public virtual DbSet<RelyFyFeedbackResponseMappingCall> RelyFyFeedbackResponseMappingCall { get; set; }
        public virtual DbSet<RelyFyFeedbackResponseMappingMail> RelyFyFeedbackResponseMappingMail { get; set; }
        public virtual DbSet<RelyfyCustomerInformation> RelyfyCustomerInformation { get; set; }
        public virtual DbSet<ReplaceKeyWord> ReplaceKeyWord { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<SecondDemoInteraction> SecondDemoInteraction { get; set; }
        public virtual DbSet<SecondDemoInteractionMeppingSteps> SecondDemoInteractionMeppingSteps { get; set; }
        public virtual DbSet<SecondDemoQuestion> SecondDemoQuestion { get; set; }
        public virtual DbSet<SecondDemoQuestionMappingAnswer> SecondDemoQuestionMappingAnswer { get; set; }
        public virtual DbSet<SendGridMailReply> SendGridMailReply { get; set; }
        public virtual DbSet<SendGridWebhookResponse> SendGridWebhookResponse { get; set; }
        public virtual DbSet<Specialization> Specialization { get; set; }
        public virtual DbSet<StateCountyData> StateCountyData { get; set; }
        public virtual DbSet<StatePropertyForEvvInfo> StatePropertyForEvvInfo { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentAddress> StudentAddress { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskHistory> TaskHistory { get; set; }
        public virtual DbSet<TempExeImport> TempExeImport { get; set; }
        public virtual DbSet<TempExeImportCounty> TempExeImportCounty { get; set; }
        public virtual DbSet<TempFbpost> TempFbpost { get; set; }
        public virtual DbSet<TestExcelImport> TestExcelImport { get; set; }
        public virtual DbSet<TwilioRecordingForProspect> TwilioRecordingForProspect { get; set; }
        public virtual DbSet<UserQuestionForSponsor> UserQuestionForSponsor { get; set; }
        public virtual DbSet<ZipCode> ZipCode { get; set; }
        public virtual DbSet<UserNotes> UserNotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=devhomecareserverdb.database.windows.net;database=RelyfyDotNetStaging;Uid=devadmin@devhomecareserverdb;Pwd=Relyfy@123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbnormalTypeForMindSituationForReadingSpecificsForPulse>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbnormalType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AbnormalTypeForMindSituationForReadingSpecificsForRespirations>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbnormalType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AbnormalTypeForSituationForReadingSpecificsForTemperature>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbnormalType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AbnormalityTypeForAppendageForCareClientPulseOxygenInformation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbnormalType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ActivityPain>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ActivityPainId).ValueGeneratedOnAdd();

                entity.Property(e => e.Back)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Chest)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ElbowL)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ElbowR)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FootL)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FootR)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HandL)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HandR)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HipL)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HipR)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KneeL)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KneeR)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ShoulderL)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShoulderR)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgencyFormBuilder>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FormName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgencyHolidayCallTypeMapping>(entity =>
            {
                entity.Property(e => e.IsHolidatPayRate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsHolidayBillRate)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgencyHolidayRates>(entity =>
            {
                entity.HasIndex(e => e.ClientLocationId)
                    .HasName("UQ__AgencyHo__CC9E69E1F29AF680")
                    .IsUnique();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.HolidayBillRate).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.HolidayPayRate).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgencyHolidays>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dates).HasColumnType("date");

                entity.Property(e => e.DayName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HolidayBillRate).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.HolidayPayRate).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgencyInteraction>(entity =>
            {
                entity.HasKey(e => e.InteractionId)
                    .HasName("PK__Prospact__922C04964CA936BB");

                entity.Property(e => e.AgencyUuid)
                    .HasColumnName("AgencyUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.InteractionDate).HasColumnType("datetime");

                entity.Property(e => e.InteractionMode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InteractionStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgencyInteractionMapping>(entity =>
            {
                entity.Property(e => e.InteractionUuid)
                    .HasColumnName("InteractionUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InteractionWith)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgencyLocations>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyUuid)
                    .IsRequired()
                    .HasColumnName("AgencyUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Zip)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgencyMilesRate>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MilesRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgencyMilesRateWithCallType>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsExpensesBillable)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsExpensesPayable)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsMilesRateBillable)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsMilesRatePayable)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MilesRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PayableMilesRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgencyOnCallInformation>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.Todate).HasColumnType("date");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.WeekType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgencyOnCallInformationMappingLocation>(entity =>
            {
                entity.Property(e => e.PrimaryScheduler)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryScheduler)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgencyOverTimeRule>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DailyProvidedHour).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.WeeklyProvidedHour).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<AgencyPaymentEmailId>(entity =>
            {
                entity.Property(e => e.PaymentEmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgencyPlanDetail>(entity =>
            {
                entity.Property(e => e.AgencyUuid)
                    .HasColumnName("AgencyUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SuscribeDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.VaultKey)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgencyRecurrence>(entity =>
            {
                entity.Property(e => e.AgencyUuid)
                    .HasColumnName("AgencyUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.RecurringAmount)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RecurringEndDate).HasColumnType("datetime");

                entity.Property(e => e.RecurringStartDate).HasColumnType("datetime");

                entity.Property(e => e.RecurringType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgencyRoidata>(entity =>
            {
                entity.ToTable("AgencyROIData");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Roiamount)
                    .HasColumnName("ROIAmount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalRolamount)
                    .HasColumnName("TotalROLAmount")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<AgencySettings>(entity =>
            {
                entity.Property(e => e.AddressForDepartmentOfCommunityHealthForComplaints).IsUnicode(false);

                entity.Property(e => e.AddressOfPersonHoldingTheInformationForAppendixL).IsUnicode(false);

                entity.Property(e => e.AgencyUuid)
                    .HasColumnName("AgencyUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GeoFenceRadiusForClockIn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfPersonHoldingTheInformationForAppendixL)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfStateAgencyForAppendixL)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TransportationContactNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransportationName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AideHousekeepingTaskScheduleMappingCareClientTaskInformationForEnvironment>(entity =>
            {
                entity.Property(e => e.TaskFrequency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaskName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaskSpecifics)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AideLaundaryTaskScheduleMappingCareClientTaskInformationForEnvironment>(entity =>
            {
                entity.Property(e => e.TaskFrequency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaskName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaskSpecifics)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AideNameListForSatisfactionOfSupervisory>(entity =>
            {
                entity.Property(e => e.AideName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Alerts>(entity =>
            {
                entity.HasKey(e => e.AlertId)
                    .HasName("PK__Alerts__EBB16A8D2AFEF06C");

                entity.Property(e => e.AlertMessage)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AlertType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CaregiverUuid)
                    .HasColumnName("CaregiverUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientUuid)
                    .HasColumnName("ClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsAlerts)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AlertsAssessmentDates>(entity =>
            {
                entity.HasKey(e => e.AlertId)
                    .HasName("PK__AlertsAs__EBB16A8DAF207C02");

                entity.Property(e => e.AlertMessage)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AlertType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Alerts62)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CaregiverUuid)
                    .HasColumnName("CaregiverUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientUuid)
                    .HasColumnName("ClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Days122).HasColumnType("datetime");

                entity.Property(e => e.Days62)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Days92).HasColumnType("datetime");

                entity.Property(e => e.IsAlerts)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SetAlerts)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AmbulationEmployeeEvalutionInformatiom>(entity =>
            {
                entity.Property(e => e.CareClientUuid)
                    .HasColumnName("CareClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CueActivityAndRom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasColumnName("NurseUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceErsorPhone)
                    .HasColumnName("PlaceERSOrPhone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Repositioning)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transfers)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Walking)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AndroidAppVersionForCarehub>(entity =>
            {
                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AndroidAppVersionForRegruit>(entity =>
            {
                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AndroidAppVersions>(entity =>
            {
                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AndroidAppVersionsForRelyfyNotes>(entity =>
            {
                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppendageTypeForReadingSpecificsForPulseOxygen>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppendageType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable("application_user");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.Property(e => e.Category)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerUuid)
                    .HasColumnName("CustomerUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeUuid)
                    .HasColumnName("EmployeeUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndAppointmentDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartAppointmentDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppointmentActivity>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("PK__Appointm__45F4A791CB413E6F");

                entity.Property(e => e.ActivityName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppointmentConfirmation>(entity =>
            {
                entity.HasKey(e => e.ConfirmId)
                    .HasName("PK__Appointm__968887030C7916FF");

                entity.Property(e => e.ConfirmedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmedOn).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppointmentMedicationMapping>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MedicineGivenTime)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MedicineName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Appointments>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.EmployeeId, e.PatientIdentifier })
                    .HasName("nci_wi_Appointments_BE21F52C3EED7A4BD46793714D6C2B02");

                entity.HasIndex(e => new { e.CreatedBy, e.EmployeeId, e.StartAppointmentDate })
                    .HasName("nci_wi_Appointments_130210FCF5F270E1D09967B84AA037ED");

                entity.HasIndex(e => new { e.EndAppointmentDate, e.ShiftId, e.StartAppointmentDate })
                    .HasName("nci_wi_Appointments_2BE6C8EF1C951B211FC1F2CC87BC3286");

                entity.HasIndex(e => new { e.EmployeeId, e.Id, e.ShiftId, e.EndAppointmentDate })
                    .HasName("nci_wi_Appointments_C374ECB24AE39E7590151C6869553DB5");

                entity.HasIndex(e => new { e.EndAppointmentDate, e.PatientIdentifier, e.EmployeeId, e.StartAppointmentDate })
                    .HasName("nci_wi_Appointments_76BB10D3694D8029A3BE6A4E2C77C066");

                entity.HasIndex(e => new { e.Id, e.EmployeeId, e.IsFacility, e.StartAppointmentDate })
                    .HasName("nci_wi_Appointments_006A26B721581D904082B9BA02AAAB39");

                entity.HasIndex(e => new { e.Id, e.MgmtPayrollId, e.PayRate, e.FacilityShiftId, e.EmployeeId })
                    .HasName("nci_wi_Appointments_B29DC17F402E60279F16476AD30A2318");

                entity.HasIndex(e => new { e.ApprovalStatus, e.EmployeeId, e.EndAppointmentDate, e.FacilityShiftId, e.Id, e.ShiftId, e.StartAppointmentDate })
                    .HasName("nci_wi_Appointments_6C23C8E4046CF77D59A3E85CC9F4379D");

                entity.HasIndex(e => new { e.BillRate, e.EmployeeId, e.Id, e.PayRate, e.ShiftId, e.ClientLocationId, e.StartAppointmentDate })
                    .HasName("nci_wi_Appointments_FEA569F7862A337EBB3334435C50E238");

                entity.HasIndex(e => new { e.ApprovalStatus, e.BillRate, e.CallTypeId, e.ClientLocationId, e.EmployeeId, e.EndAppointmentDate, e.MgmtRatesId, e.PatientIdentifier, e.PayRate, e.ShiftId, e.Id, e.StartAppointmentDate })
                    .HasName("nci_wi_Appointments_37198CE1A5F7B5A2FC0973C0E8C9C7C0");

                entity.HasIndex(e => new { e.CareNotesForFacilityShift, e.CgAckTime, e.ClientLocationId, e.CreatedBy, e.EndAppointmentDate, e.FacilityShiftId, e.Id, e.PatientIdentifier, e.ShiftId, e.EmployeeId, e.IsFacility, e.StartAppointmentDate })
                    .HasName("nci_wi_Appointments_ED8527A981440318DA69A7B8B51D486F");

                entity.Property(e => e.AppointmentFor)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CancellationBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationDate).HasColumnType("datetime");

                entity.Property(e => e.CancellationReason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CareClientApprovalBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CareClientApprovalTime).HasColumnType("datetime");

                entity.Property(e => e.CareNotesForFacilityShift).HasColumnType("varchar(max)");

                entity.Property(e => e.CaregiverApprovalBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CaregiverApprovalStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CaregiverApprovalTime).HasColumnType("datetime");

                entity.Property(e => e.CaregiverApprovalType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CaregiverOverTimeHour).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CgAckTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Duration)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndAppointmentDate).HasColumnType("datetime");

                entity.Property(e => e.FacilityRateType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FacilityTimeType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HolidayBillRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.HolidayPayRate)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IsFacility)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsHoliday)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MilesRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Patient)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientIdentifier)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PayRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PayableMilesRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PayrollStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StaffUuid)
                    .HasColumnName("StaffUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartAppointmentDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppointmentsNurseApproval>(entity =>
            {
                entity.HasIndex(e => e.AppointmentId)
                    .HasName("UQ__Appointm__8ECDFCC3B064E164")
                    .IsUnique();

                entity.Property(e => e.NurseSignatureUrl).IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasColumnName("NurseUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppointmentsRequest>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AppointmentFor)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.CancellationReason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Duration)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EndAppointmentDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Patient)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientIdentifier)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Provider)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonOfReject)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartAppointmentDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AssessorPayrollTerms>(entity =>
            {
                entity.Property(e => e.AssessorUuid)
                    .HasColumnName("AssessorUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.PayRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssessorScreenList>(entity =>
            {
                entity.Property(e => e.ScreenName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssessorScreenMappingLevel>(entity =>
            {
                entity.Property(e => e.Level1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Level2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssessorScrrenListMappingMandatoryQues>(entity =>
            {
                entity.Property(e => e.ColumnName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MandatoryQues).IsUnicode(false);
            });

            modelBuilder.Entity<AssignForms>(entity =>
            {
                entity.HasKey(e => e.AssignId)
                    .HasName("PK__AssignFo__9FFF4CAFF79956CD");

                entity.Property(e => e.AgreementDate).HasColumnType("datetime");

                entity.Property(e => e.AssignedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AssignedOn).HasColumnType("datetime");

                entity.Property(e => e.AssignedTo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BehalfOfB)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BehalfOfP)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SignedByB)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SignedByP)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BenefitLinksForApp>(entity =>
            {
                entity.Property(e => e.Link).IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BillPayRateChangeLog>(entity =>
            {
                entity.Property(e => e.CareClientUuid)
                    .HasColumnName("CareClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CurrentBillRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PreviousBillRate).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<BodyTemperatureWaysForReadingSpecificsForTemperature>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BodyTemperatureWays)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessContactCounty>(entity =>
            {
                entity.HasIndex(e => e.BusinessContactId)
                    .HasName("idx_BusinessCounty_BusinessContactId");

                entity.HasIndex(e => e.County)
                    .HasName("idx_BusinessCounty_County");

                entity.Property(e => e.County)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessContactInformation>(entity =>
            {
                entity.HasKey(e => e.Uuid)
                    .HasName("PK__Prospact__65A475E7B67CFD77");

                entity.HasIndex(e => e.EmailId)
                    .HasName("BusinessEmail_Idx");

                entity.HasIndex(e => e.State)
                    .HasName("BusinessState_Idx");

                entity.HasIndex(e => e.Status)
                    .HasName("BusienessStatus_Idx");

                entity.HasIndex(e => new { e.EmailId, e.Status })
                    .HasName("nci_wi_BusinessContactInformation_B1B9CCCD333C9AA963CAE0764689CFF2");

                entity.HasIndex(e => new { e.ClientLocation, e.IsClient, e.Status })
                    .HasName("nci_wi_BusinessContactInformation_9765E0619127322F4C1ADCB7B08D2EF1");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyProviderType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AgencySource)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ahcanumber)
                    .HasColumnName("AHCANumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoClock)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BounceDate).HasColumnType("datetime");

                entity.Property(e => e.BusinessName).IsUnicode(false);

                entity.Property(e => e.CareonomyPoints).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClientLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CmscertificationNumber)
                    .HasColumnName("CMSCertificationNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUrl).IsUnicode(false);

                entity.Property(e => e.ControllingInterest)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.County).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateCertified).HasColumnType("datetime");

                entity.Property(e => e.DateOfFirstContact).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedHourPerWeek).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ExpectedValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FanCount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FbImgUrl)
                    .HasColumnName("FbImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.FbLinkStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fblink)
                    .HasColumnName("FBLink")
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUp)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("ImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.InactiveReason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IndeedProfileUrl).IsUnicode(false);

                entity.Property(e => e.IsCareJitProspect)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCareonomyProspect)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsClient)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsLoginCarePlan)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsLoginRelyfyFamily)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsRegruitProspect)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastFbpost)
                    .HasColumnName("LastFBPost")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseEffectiveDate).HasColumnType("date");

                entity.Property(e => e.LicenseExpirationDate).HasColumnType("date");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LicensedBeds)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LinkedInImgUrl)
                    .HasColumnName("LinkedInImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.LinkedInProfile).IsUnicode(false);

                entity.Property(e => e.Lng)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddressLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MapLocation).IsUnicode(false);

                entity.Property(e => e.Marketer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Owner)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerSince).HasColumnType("date");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryCaseManager)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileTag)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Referral)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Scheduler)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Stage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TwiterLink).IsUnicode(false);

                entity.Property(e => e.TwitterImgUrl)
                    .HasColumnName("TwitterImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfOwnership)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UnsubscribeDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebImgUrl)
                    .HasColumnName("WebImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.WebUrl).IsUnicode(false);

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.YaaHrpoint)
                    .HasColumnName("YaaHRPoint")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<BusinessContactInformationCopy>(entity =>
            {
                entity.HasKey(e => e.Uuid)
                    .HasName("PK__Business__65A475E745811D22");

                entity.ToTable("BusinessContactInformation_copy");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ahcanumber)
                    .HasColumnName("AHCANumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoClock)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName).IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClientLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CmscertificationNumber)
                    .HasColumnName("CMSCertificationNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUrl).IsUnicode(false);

                entity.Property(e => e.ControllingInterest)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.County).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateCertified).HasColumnType("datetime");

                entity.Property(e => e.DateOfFirstContact).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedHourPerWeek).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ExpectedValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FanCount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FbImgUrl)
                    .HasColumnName("FbImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.Fblink)
                    .HasColumnName("FBLink")
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUp)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("ImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.InactiveReason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsClient)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsLoginCarePlan)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsLoginRelyfyFamily)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseEffectiveDate).HasColumnType("date");

                entity.Property(e => e.LicenseExpirationDate).HasColumnType("date");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LicensedBeds)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LinkedInImgUrl)
                    .HasColumnName("LinkedInImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.LinkedInProfile).IsUnicode(false);

                entity.Property(e => e.Lng)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddressLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Marketer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Owner)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerSince).HasColumnType("date");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryCaseManager)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileTag)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Referral)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Scheduler)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Stage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TwiterLink).IsUnicode(false);

                entity.Property(e => e.TwitterImgUrl)
                    .HasColumnName("TwitterImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfOwnership)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebImgUrl)
                    .HasColumnName("WebImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.WebUrl).IsUnicode(false);

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessContactInformationLatestCanary>(entity =>
            {
                entity.HasKey(e => e.Uuid)
                    .HasName("PK__Business__65A475E7E993660C");

                entity.ToTable("BusinessContactInformation_LatestCanary");

                entity.HasIndex(e => e.County)
                    .HasName("BusinessCounty_Idx");

                entity.HasIndex(e => e.EmailId)
                    .HasName("BusinessEmail_Idx");

                entity.HasIndex(e => e.State)
                    .HasName("BusinessState_Idx");

                entity.HasIndex(e => e.Status)
                    .HasName("BusienessStatus_Idx");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyProviderType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AgencySource)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ahcanumber)
                    .HasColumnName("AHCANumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoClock)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClientLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CmscertificationNumber)
                    .HasColumnName("CMSCertificationNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUrl).IsUnicode(false);

                entity.Property(e => e.ControllingInterest)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateCertified).HasColumnType("datetime");

                entity.Property(e => e.DateOfFirstContact).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedHourPerWeek).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ExpectedValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FanCount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FbImgUrl)
                    .HasColumnName("FbImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.FbLinkStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fblink)
                    .HasColumnName("FBLink")
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUp)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("ImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.InactiveReason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsCareJitProspect)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCareonomyProspect)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsClient)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsLoginCarePlan)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsLoginRelyfyFamily)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsRegruitProspect)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastFbpost)
                    .HasColumnName("LastFBPost")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseEffectiveDate).HasColumnType("date");

                entity.Property(e => e.LicenseExpirationDate).HasColumnType("date");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LicensedBeds)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LinkedInImgUrl)
                    .HasColumnName("LinkedInImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.LinkedInProfile).IsUnicode(false);

                entity.Property(e => e.Lng)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddressLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MapLocation).IsUnicode(false);

                entity.Property(e => e.Marketer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Owner)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerSince).HasColumnType("date");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryCaseManager)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileTag)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Referral)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Scheduler)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Stage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TwiterLink).IsUnicode(false);

                entity.Property(e => e.TwitterImgUrl)
                    .HasColumnName("TwitterImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfOwnership)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebImgUrl)
                    .HasColumnName("WebImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.WebUrl).IsUnicode(false);

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessContactMappingFbPost>(entity =>
            {
                entity.HasIndex(e => e.TimeStamp)
                    .HasName("FBTimeStamp_Idx");

                entity.HasIndex(e => e.Uuid)
                    .HasName("FBPostUUID");

                entity.HasIndex(e => new { e.FbPostText, e.Uuid, e.PostDate })
                    .HasName("nci_wi_BusinessContactMappingFbPost_FB7371309F9475B4BC97B4174878C5E5");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FbPostText).HasColumnType("varchar(max)");

                entity.Property(e => e.Image).IsUnicode(false);

                entity.Property(e => e.Link).IsUnicode(false);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PostUrl).IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessContactMappingFbPostLatestCanary>(entity =>
            {
                entity.ToTable("BusinessContactMappingFbPost_LatestCanary");

                entity.HasIndex(e => e.TimeStamp)
                    .HasName("FBTimeStamp_Idx");

                entity.HasIndex(e => e.Uuid)
                    .HasName("FBPostUUID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FbPostText).IsUnicode(false);

                entity.Property(e => e.Image).IsUnicode(false);

                entity.Property(e => e.Link).IsUnicode(false);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PostUrl).IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessContactMappingService>(entity =>
            {
                entity.HasIndex(e => e.BusinessUuid)
                    .HasName("nci_wi_BusinessContactMappingService_A0BA211E564DBBA6686D4C501E42780A");

                entity.Property(e => e.BusinessUuid)
                    .HasColumnName("BusinessUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessContactMappingServiceLatestCanary>(entity =>
            {
                entity.ToTable("BusinessContactMappingService_LatestCanary");

                entity.Property(e => e.BusinessUuid)
                    .HasColumnName("BusinessUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessContactMappingTag>(entity =>
            {
                entity.HasIndex(e => e.BusinessUuid)
                    .HasName("BusinessUUIDTag_Idx");

                entity.HasIndex(e => e.TagId)
                    .HasName("TagId_Idx");

                entity.Property(e => e.BusinessUuid)
                    .HasColumnName("BusinessUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessContactMappingTagLatestCanary>(entity =>
            {
                entity.ToTable("BusinessContactMappingTag_LatestCanary");

                entity.Property(e => e.BusinessUuid)
                    .HasColumnName("BusinessUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessContactMappingWebsiteText>(entity =>
            {
                entity.HasIndex(e => e.Uuid)
                    .HasName("WebTextUUID_idx");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebsiteText).IsUnicode(false);
            });

            modelBuilder.Entity<BusinessContactMappingWebsiteTextLatestCanary>(entity =>
            {
                entity.ToTable("BusinessContactMappingWebsiteText_LatestCanary");

                entity.HasIndex(e => e.Uuid)
                    .HasName("WebTextUUID_idx");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebsiteText).IsUnicode(false);
            });

            modelBuilder.Entity<BusinessIndeedJobData>(entity =>
            {
                entity.Property(e => e.AgencyAboutUs).IsUnicode(false);

                entity.Property(e => e.BusinessUuid)
                    .HasColumnName("BusinessUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FacebookAddress).IsUnicode(false);

                entity.Property(e => e.HeadquartersAddress).IsUnicode(false);

                entity.Property(e => e.IndeedRating)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.JobDescription).IsUnicode(false);

                entity.Property(e => e.JobLocation).IsUnicode(false);

                entity.Property(e => e.JobPostedDate).IsUnicode(false);

                entity.Property(e => e.JobTitle).IsUnicode(false);

                entity.Property(e => e.NumberOfCompanyReviews).IsUnicode(false);

                entity.Property(e => e.NumberOfEmployees)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Revenue)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);

                entity.Property(e => e.TotalReviews)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TwitterAddress).IsUnicode(false);

                entity.Property(e => e.WebSiteAddress).IsUnicode(false);
            });

            modelBuilder.Entity<BusinessInteraction>(entity =>
            {
                entity.Property(e => e.AgencyUuid)
                    .HasColumnName("AgencyUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessUuid)
                    .HasColumnName("BusinessUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfLastCall).HasColumnType("datetime");

                entity.Property(e => e.InteractionType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.OtherContactUuid)
                    .HasColumnName("OtherContactUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Stage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<BusinessLabelList>(entity =>
            {
                entity.Property(e => e.Label)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessMailInteraction>(entity =>
            {
                entity.Property(e => e.BusinessUuid)
                    .HasColumnName("BusinessUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailBody).IsUnicode(false);

                entity.Property(e => e.MailSubject).IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SendGridMessageId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<BusinessMappingCountyServed>(entity =>
            {
                entity.Property(e => e.BusinessUuid)
                    .HasColumnName("BusinessUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessMappingLabel>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessMappingStateServed>(entity =>
            {
                entity.Property(e => e.BusinessUuid)
                    .HasColumnName("BusinessUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessOtherContact>(entity =>
            {
                entity.HasKey(e => e.Uuid)
                    .HasName("PK__Prospect__65A475E72DFA8F33");

                entity.HasIndex(e => new { e.FirstName, e.LastName })
                    .HasName("nci_wi_ProspectOtherContact_294B554B70DD9C0607D7655DF13E3D76");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ahcanumber)
                    .HasColumnName("AHCANumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BounceDate).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClientLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ControllingInterest)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfFirstContact).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedHourPerWeek).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ExpectedValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fblink)
                    .HasColumnName("FBLink")
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUp)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InactiveReason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseEffectiveDate).HasColumnType("date");

                entity.Property(e => e.LicenseExpirationDate).HasColumnType("date");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LicensedBeds)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddressLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Owner)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerSince).HasColumnType("date");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProspectUuid)
                    .HasColumnName("ProspectUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Referral)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TwiterLink).IsUnicode(false);

                entity.Property(e => e.UnsubscribeDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebUrl).IsUnicode(false);

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessOtherContactLatestCanary>(entity =>
            {
                entity.HasKey(e => e.Uuid)
                    .HasName("PK__Business__65A475E73B5865FD");

                entity.ToTable("BusinessOtherContact_LatestCanary");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ahcanumber)
                    .HasColumnName("AHCANumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClientLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ControllingInterest)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfFirstContact).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedHourPerWeek).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ExpectedValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fblink)
                    .HasColumnName("FBLink")
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUp)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InactiveReason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseEffectiveDate).HasColumnType("date");

                entity.Property(e => e.LicenseExpirationDate).HasColumnType("date");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LicensedBeds)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddressLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Owner)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerSince).HasColumnType("date");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProspectUuid)
                    .HasColumnName("ProspectUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Referral)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TwiterLink).IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebUrl).IsUnicode(false);

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessScoringCriteria>(entity =>
            {
                entity.HasIndex(e => e.Uuid)
                    .HasName("nci_wi_BusinessScoringCriteria_AC0CFB37D6D04FBAF03BF2D808CC6E75");

                entity.Property(e => e.CareonomyJson).IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.YaaHrjson)
                    .HasColumnName("YaaHRJson")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessServiceTags>(entity =>
            {
                entity.HasIndex(e => e.TagName)
                    .HasName("TagName");

                entity.Property(e => e.TagName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CallType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CallTypeCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CallTypeDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CallTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.CallTypeStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.SageEarningCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CancelAppointments>(entity =>
            {
                entity.HasIndex(e => new { e.CancelBy, e.Reason, e.AppointmentId })
                    .HasName("nci_wi_CancelAppointments_8F3561846ACBD8E393C5385605B533B3");

                entity.Property(e => e.CancelBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Reason).HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<CareBusinessForumLeads>(entity =>
            {
                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StateList).IsUnicode(false);
            });

            modelBuilder.Entity<CareBusinessForumQuestionList>(entity =>
            {
                entity.Property(e => e.Question).IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareBusinessForumQuestionMappingAnswer>(entity =>
            {
                entity.HasIndex(e => e.EmailId)
                    .HasName("EmailCareBusinessForum_Idx");

                entity.HasIndex(e => e.OptionId)
                    .HasName("OptionIdCareBusinessForum_Idx");

                entity.HasIndex(e => e.QuestionId)
                    .HasName("QuestionIdCareBusinessForum_Idx");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OtherValue)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareBusinessForumQuestionMappingOption>(entity =>
            {
                entity.Property(e => e.Option)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareBusinessForumQuestionMappingOptionCopy>(entity =>
            {
                entity.ToTable("CareBusinessForumQuestionMappingOption_copy");

                entity.Property(e => e.Option)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareBusinessForumQuestionMappingSubOption>(entity =>
            {
                entity.Property(e => e.SubOption)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareBusinessForumUpdatedInfo>(entity =>
            {
                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateList).IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareClientAdvanceDirectiveInformation>(entity =>
            {
                entity.Property(e => e.AnswerForAdvanceDirective).IsUnicode(false);

                entity.Property(e => e.CareClientUuid)
                    .HasColumnName("CareClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DidClientGiveCopy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationOfDocument)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasColumnName("NurseUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientAdvanceDirectiveMappingDocument>(entity =>
            {
                entity.Property(e => e.DocName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareClientAllergyInformation>(entity =>
            {
                entity.Property(e => e.CareClientUuid)
                    .HasColumnName("CareClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EnvironmentalAllergy).IsUnicode(false);

                entity.Property(e => e.FoodAllergy).IsUnicode(false);

                entity.Property(e => e.IsEnvironmentalAllergy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsFoodAllergy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsMedicalAllergy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalAllergy).IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasColumnName("NurseUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientAndNurseSignature>(entity =>
            {
                entity.Property(e => e.CareClientUuid)
                    .HasColumnName("CareClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientSignatureUrl)
                    .HasColumnName("ClientSignatureURL")
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.NurseSignatureUrl)
                    .HasColumnName("NurseSignatureURL")
                    .IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasColumnName("NurseUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientAppearance>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CareCientUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientGeneralAppearance)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FirstCorrespondingDiagnosis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Height)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsOnOxygen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OxygenLiters)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondCorrespondigDiagnosis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdetedOn).HasColumnType("datetime");

                entity.Property(e => e.Weight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WeightMonitorShift)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WeightMonitoringSchedule)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareClientAttchments>(entity =>
            {
                entity.Property(e => e.CareClientUuid)
                    .HasColumnName("CareClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.TagName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Urls)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareClientBloodPressureInformation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArmReadingSpecifics)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BpmonitoringSchedule)
                    .HasColumnName("BPMonitoringSchedule")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BpreadingDia)
                    .HasColumnName("BPReadingDia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BpreadingSys)
                    .HasColumnName("BPReadingSys")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CareClientUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateAlertAtBpdia)
                    .HasColumnName("CreateAlertAtBPDia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateAlertAtBpsys)
                    .HasColumnName("CreateAlertAtBPSys")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FirstCorrespondingDxforBp)
                    .HasColumnName("FirstCorrespondingDXForBP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoCorrespondingDxforBp)
                    .HasColumnName("NoCorrespondingDXForBP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PositionReadingSpecifics)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReadingSpecifics)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Refused)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondCorrespondingDxforBp)
                    .HasColumnName("SecondCorrespondingDXForBP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SplitShiftMonitoring)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientBloodPressureMappingAbnormality>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbnormalType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareClientCardiovascularInformation>(entity =>
            {
                entity.Property(e => e.AssistLevelForBreathing)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CapillaryRefill)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CareClientUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DoesHaveAnyLimitation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstCorrespondingDxforCardio)
                    .HasColumnName("FirstCorrespondingDXForCardio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoCorrespondingDxforCardio)
                    .HasColumnName("NoCorrespondingDXForCardio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SecondCorrespondingDxforCardio)
                    .HasColumnName("SecondCorrespondingDXForCardio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientCardiovascularInformationMappingHeartSound>(entity =>
            {
                entity.Property(e => e.HeartSound)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareClientCardiovascularInformationMappingShortnessOfBreathWithActivity>(entity =>
            {
                entity.Property(e => e.Activity)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareClientCardiovascularInformationMappingShortnessOfBreathWithoutActivity>(entity =>
            {
                entity.Property(e => e.Activity)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareClientCarePlan>(entity =>
            {
                entity.Property(e => e.CareClientUuid)
                    .HasColumnName("CareClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CarePlanName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CarePlanStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientConnectLogin>(entity =>
            {
                entity.HasIndex(e => e.MobileNo)
                    .HasName("UQ__CareClie__D6D73A86499817B0")
                    .IsUnique();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeviceType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("ImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.IsMobileVerified)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsVerified)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UserStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareClientContactInformation>(entity =>
            {
                entity.HasKey(e => e.Uuid)
                    .HasName("PK__CareClie__65A475E798635BB6");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName).IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClientLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfFirstContact).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FanCount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUp)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InactiveReason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Marketer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryCaseManager)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Referral)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Scheduler)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareClientContactInformationCopy>(entity =>
            {
                entity.HasKey(e => e.Uuid)
                    .HasName("PK__CareClie__65A475E77CCDA79D");

                entity.ToTable("CareClientContactInformation_copy");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CareDeliveryAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CareDeliveryAddressLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CareDeliveryCity)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CareDeliveryCountry)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CareDeliveryState)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CareDeliveryZipCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientIdentifier)
                    .HasColumnName("Client_Identifier ")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientLocationId)
                    .HasColumnName("ClientLocationID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsPrimaryAddressAsCareDelivery)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsVeteran)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Languages)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaritalState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Office)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeNotes).IsUnicode(false);

                entity.Property(e => e.OtherPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordSalt)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianAddressLine1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianAddressLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianCity)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianCountry)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianFax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianOfficePhone)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianState)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianZipCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralUuid)
                    .HasColumnName("ReferralUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SpouseName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartOfCase)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TokenId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.VaultKey)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareClientContactInformationOld>(entity =>
            {
                entity.HasKey(e => e.Uuid)
                    .HasName("PK__CareClie__65A475E74117B327");

                entity.ToTable("CareClientContactInformation_old");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CareDeliveryAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CareDeliveryAddressLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CareDeliveryCity)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CareDeliveryCountry)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CareDeliveryState)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CareDeliveryZipCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientIdentifier)
                    .HasColumnName("Client_Identifier ")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientLocationId)
                    .HasColumnName("ClientLocationID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FacilityUuid)
                    .HasColumnName("FacilityUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsPrimaryAddressAsCareDelivery)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsVeteran)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Languages)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaritalState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Office)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeNotes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OtherPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordSalt)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianAddressLine1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianAddressLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianCity)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianCountry)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianFax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianOfficePhone)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianState)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianZipCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralUuid)
                    .HasColumnName("ReferralUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SpouseName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartOfCase)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TokenId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.VaultKey)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareClientDiagnosis>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnyChanges)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CareClientUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Changes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.NurseUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdetedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdetedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientDiagnosisMappig>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alteration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosisPriority)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DxSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icd10)
                    .HasColumnName("ICD10")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsPrimary)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ques).IsUnicode(false);
            });

            modelBuilder.Entity<CareClientDiegestionMouthInformationMappingLimitation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<CareClientDigestionGastrointestinalInformation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BmmonitoringSchedule)
                    .HasColumnName("BMMonitoringSchedule")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BowelProgramPerformBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BowelProgramSchedule)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CareClientUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfLastBm)
                    .HasColumnName("DateOfLastBM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DoesRequiredBowelProgram)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCorrespondingLimitation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SecondCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientDigestionGastrointestinalInformationMappingLimitation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<CareClientDigestionGenitourinaryBladderIncontinenceLimitation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Occassional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareClientDigestionGenitourinaryInformation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssistLevelForToileting)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CareClientUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CareSchedule)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatheterType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FirstCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCorrespondingLimitation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsRequireCatheter)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SecondCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Toileting)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientDigestionGenitourinaryInformationMappingLimitation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<CareClientDigestionMouthDenturesLimitation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lowers)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uppers)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareClientDigestionMouthInformation>(entity =>
            {
                entity.ToTable("careClientDigestionMouthInformation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CareClientUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CcsPerDay)
                    .HasColumnName("CCsPerDay")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FirstCorrespondinDxforHearing)
                    .HasColumnName("FirstCorrespondinDXForHearing")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsClientOnFluidRestriction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCorrespondingLimitation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoCorrespondinDxforHearing)
                    .HasColumnName("NoCorrespondinDXForHearing")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SecondCorrespondinDxforHearing)
                    .HasColumnName("SecondCorrespondinDXForHearing")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientDisasterInformation>(entity =>
            {
                entity.Property(e => e.CareClientUuid)
                    .HasColumnName("CareClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientsDisasterLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.HospitalPreference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasColumnName("NurseUUId")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientDischargeInformation>(entity =>
            {
                entity.Property(e => e.CanClientParticipateInTheDischargePlanningProcess)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CareClientUuid)
                    .HasColumnName("CareClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChoiceOfArrangementOfFirstPreference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChoiceOfArrangementOfSecondPreference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientHealthPrognosis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsFamilyPresentAndParticipatingInThePlanningProcess)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfFamilyMember)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasColumnName("NurseUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecificsOfFirstPreference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecificsOfSecondPreference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.WhyNotClientCanParticipateInDischargePlan)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareClientEarsInformation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssstLevelForHearing)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CareClientUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FirstCorrespondingDiagnosis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCorrespondingDxforHearing)
                    .HasColumnName("IsCorrespondingDXforHearing")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCorrespondingLimitation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LevelOfHearingLoss)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SecondCorrespondingDiagnosis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientEarsInformationMappingLimitation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LeftEar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RightEar)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareClientEventsInformation>(entity =>
            {
                entity.Property(e => e.AnyChangesInLastAppointment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AnyNewMedicationsOrDiagnosesNotReflectedOnLists)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CareClientUuid)
                    .HasColumnName("CareClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfAppointment).HasColumnType("date");

                entity.Property(e => e.DateOfMedicationChanges).HasColumnType("date");

                entity.Property(e => e.DescribeTheChange)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DoesClientHaveHistoryOfFalls)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FallRisk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FallenDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HasClientFallenRecently)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HasClientHadAnyRecentHospitalizations)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HasClientHadAnyRecentMedicationChanges)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalizationDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LengthOfStayOfHospitalization)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewMedicationDetails)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasColumnName("NurseUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicianName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonForAppointment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonForFall)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonForHospitalization)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Speciality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientEyesInformaion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssistLevelForVision)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CareClientUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FirstCorrespondingDxforVision)
                    .HasColumnName("FirstCorrespondingDXForVision")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCorrespondingDxforVision)
                    .HasColumnName("IsCorrespondingDXForVision")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCorrespondingLimitation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LevelOfVisionLoss)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SecondCorrespondingDxforVision)
                    .HasColumnName("SecondCorrespondingDXForVision")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondCorrespondingSurgery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientEyesInformationMappingEyesLimitations>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<CareClientGeneralPainInformation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CareClientPainInformationId).HasColumnName("CareClientPainInformationID");

                entity.Property(e => e.DoesGenralPainAffectSleep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntensityLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WhatBringReliefFromGeneralPain)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareClientGlucoseInformation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CareClientUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientDiabetic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateAlertWhenBloodSugarDia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateAlertWhenBloodSugarSys)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CurrentGlucoseReading)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiabetesType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GlucoseMonitoringSchedule)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Refused)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SplitShift)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientGlucoseInformationMappingTestingPerformBy>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<CareClientGlucoseMappingGlucoseManagedBy>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<CareClientGoalsInformation>(entity =>
            {
                entity.Property(e => e.CareClientUuid)
                    .HasColumnName("CareClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DoesClientGivingHomecareResultOfHivscreening)
                    .HasColumnName("DoesClientGivingHomecareResultOfHIVScreening")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Goals).IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasColumnName("NurseUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientHeadNeckInformation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CareClientUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsCorrespondingLimitation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NurseUuid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientHeadNeckInformationMappingLimitation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<CareClientHolidayStatus>(entity =>
            {
                entity.HasIndex(e => e.CareClientUuid)
                    .HasName("UQ__CareClie__FE331D27C21B70A9")
                    .IsUnique();

                entity.Property(e => e.CareClientUuid)
                    .IsRequired()
                    .HasColumnName("CareClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsHoliday)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsWeekend)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientImportantInformation>(entity =>
            {
                entity.HasKey(e => e.CareClientInformationId)
                    .HasName("PK__CareClie__B01FE2A97DD4B2B7");

                entity.Property(e => e.CareClientUuid)
                    .HasColumnName("CareClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CaregiverNotes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CaregiverPreferance)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExternalCaseManager)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InternalCaseManager)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Marketer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PayerGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Scheduler)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientInformationForPolici>(entity =>
            {
                entity.Property(e => e.CareClientUuid)
                    .HasColumnName("CareClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.NurseUuid)
                    .HasColumnName("NurseUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientInteractionDetails>(entity =>
            {
                entity.HasKey(e => e.InteractionId)
                    .HasName("PK__CareClie__922C0496E3EC92E5");

                entity.Property(e => e.CareClientUuid)
                    .HasColumnName("CareClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.InteractionDate).HasColumnType("datetime");

                entity.Property(e => e.InteractionMode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InteractionStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareClientMappingService>(entity =>
            {
                entity.Property(e => e.CareClientUuid)
                    .HasColumnName("CareClientUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaryfySupportEmail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DbDataCreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromUser)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.StateId).HasColumnName("StateID");
            });

            modelBuilder.Entity<ClientContactPerson>(entity =>
            {
                entity.HasIndex(e => e.EmailId)
                    .HasName("UQ__ClientCo__7ED91ACE93361BDD")
                    .IsUnique();

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientIdentifier)
                    .IsRequired()
                    .HasColumnName("Client_Identifier ")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Credentials)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FacebookLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InBusinessSince)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsVeraMedix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsVeraNutri)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LogoImage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordSalt)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PracticeName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Registration)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SkypeId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TwitterLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientContactPersonCopy>(entity =>
            {
                entity.ToTable("ClientContactPerson_copy");

                entity.HasIndex(e => e.EmailId)
                    .HasName("UQ__ClientCo__7ED91ACE1FD5B0A5")
                    .IsUnique();

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientIdentifier)
                    .IsRequired()
                    .HasColumnName("Client_Identifier ")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Credentials)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FacebookLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InBusinessSince)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsVeraMedix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsVeraNutri)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LogoImage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordSalt)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PracticeName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Registration)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SkypeId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TwitterLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientLocations>(entity =>
            {
                entity.HasKey(e => e.ClientLocationId)
                    .HasName("PK__ClientLo__CC9E69E0718D7296");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.EmailId })
                    .HasName("PK__Clients__01938B88F9A86800");

                entity.HasIndex(e => e.EmailId)
                    .HasName("UQ__Clients__7ED91ACECB3B3B65")
                    .IsUnique();

                entity.Property(e => e.ClientId).ValueGeneratedOnAdd();

                entity.Property(e => e.EmailId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ActivationDate).HasColumnType("datetime");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientIdentifier)
                    .IsRequired()
                    .HasColumnName("Client_Identifier")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CogentEmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerContactMappingTag>(entity =>
            {
                entity.Property(e => e.CustomerUuid)
                    .HasColumnName("CustomerUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerInteraction>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerUuid)
                    .HasColumnName("CustomerUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfLastCall).HasColumnType("datetime");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeUuid)
                    .HasColumnName("EmployeeUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InteractionType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Stage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerMailInteraction>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailBody).IsUnicode(false);

                entity.Property(e => e.MailSubject).IsUnicode(false);

                entity.Property(e => e.SendGridMessageId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DashBoardManagement>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BillingHours)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClintLocationId)
                    .HasColumnName("ClintLocationID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Identifier)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NewClients)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NewProspects)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Roles)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StarRatings)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TimeArrival)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TotalClints)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Totalcaregiver)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataScrapAgency>(entity =>
            {
                entity.Property(e => e.AgencyAddress)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyServices)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyTelephone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CityUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FbprocessState).HasColumnName("FBProcessState");

                entity.Property(e => e.Fburl)
                    .HasColumnName("FBUrl")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleCardMapUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleCardPhone)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleCardWebUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleSearchLinkRatio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleSearchRatio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleSearchTitleRatio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleSearchWebUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StateUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.DataScrapAgency)
                    .HasForeignKey(d => d.ProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DataScrapAgency_DataScrapeProcess");
            });

            modelBuilder.Entity<DataScrapeProcess>(entity =>
            {
                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DossierRequest>(entity =>
            {
                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DossierUrl).IsUnicode(false);

                entity.Property(e => e.MailBody).IsUnicode(false);

                entity.Property(e => e.MailSubject).IsUnicode(false);

                entity.Property(e => e.RequestBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseDate).HasColumnType("datetime");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DossierRequestMappingNextlinkEmail>(entity =>
            {
                entity.Property(e => e.NextlickEmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailAnalystFromExcel>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email).IsUnicode(false);
            });

            modelBuilder.Entity<EmailCampaignMappingTemplate>(entity =>
            {
                entity.Property(e => e.Condition)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MailDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.Property(e => e.AgencyUuid)
                    .HasColumnName("AgencyUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Body).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Event)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Subject).IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeAvailability>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeBusinessAccess>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeBusinessAccessMappingCounty>(entity =>
            {
                entity.Property(e => e.County)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeBusinessAccessMappingProduct>(entity =>
            {
                entity.Property(e => e.ProductType)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeBusinessAccessMappingService>(entity =>
            {
                entity.Property(e => e.ServiceType)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeBusinessAccessMappingState>(entity =>
            {
                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeFavouriteItem>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmployeeUuid)
                    .HasColumnName("EmployeeUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeFavouriteItemLog>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeUuid)
                    .HasColumnName("EmployeeUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TblEvent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeOtherContact>(entity =>
            {
                entity.HasKey(e => e.Uuid)
                    .HasName("PK__Employee__65A475E7F0EC19F8");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Emergency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyInstruction)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeUuid)
                    .HasColumnName("EmployeeUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Family)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OtherPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RelationShip)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Employee__7AD04F11EF10BC4B");

                entity.HasIndex(e => new { e.EmailId, e.ClientLocationId })
                    .HasName("UQ__Employee__6210FC50C412575B")
                    .IsUnique();

                entity.Property(e => e.AccessType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CityId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Credentials)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfJoining)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceRegistrationId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Identifier)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InactiveReason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IndependentContractor)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsEmailReceived)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordSalt)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("numeric(12, 2)");

                entity.Property(e => e.Sex)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpoyeeFeatureMapping>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeUuid)
                    .HasColumnName("EmployeeUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasIndex(e => e.StartDate)
                    .HasName("Idx_EventStartDate");

                entity.Property(e => e.ChannelType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EventKindUuid)
                    .HasColumnName("EventKindUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Product)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EventEmailSent>(entity =>
            {
                entity.Property(e => e.Body).IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromEmail).IsUnicode(false);

                entity.Property(e => e.ScheduleDate).HasColumnType("datetime");

                entity.Property(e => e.SendGridId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.Subject).IsUnicode(false);

                entity.Property(e => e.ToEmail).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EventKindBusinessData>(entity =>
            {
                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EventKindUserDetail>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EventKindUserUuid)
                    .HasColumnName("EventKindUserUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EventKindUuid)
                    .HasColumnName("EventKindUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EventStartDatetime).HasColumnType("datetime");

                entity.Property(e => e.EventTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Json).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EventKindUserLoggedInDetails>(entity =>
            {
                entity.HasIndex(e => e.UserEmail)
                    .HasName("IX_UserLoggedInDetails");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoggedInDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EventOrganizer>(entity =>
            {
                entity.HasIndex(e => e.Uuid)
                    .HasName("Idx_EventOrganizerUUID");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EventParticipant>(entity =>
            {
                entity.HasIndex(e => e.Uuid)
                    .HasName("Idx_EventParticipantUUID");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EvvinfoMappingState>(entity =>
            {
                entity.ToTable("EVVInfoMappingState");

                entity.Property(e => e.DocumentUrl)
                    .HasColumnName("DocumentURL")
                    .IsUnicode(false);

                entity.Property(e => e.EvvcompatibleInfo)
                    .HasColumnName("EVVCompatibleInfo")
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.ReferralCompanyEvvinfoId).HasColumnName("ReferralCompanyEVVInfoId");

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FeatureEmployeeMapping>(entity =>
            {
                entity.HasIndex(e => new { e.EmployeeUuid, e.FeatureId })
                    .HasName("UQ__FeatureE__E83B42E43BAD6241")
                    .IsUnique();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmployeeUuid)
                    .HasColumnName("EmployeeUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<FeatureRoleMappings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Features>(entity =>
            {
                entity.HasKey(e => e.FeatureId)
                    .HasName("PK__Features__82230BC92F0E3C17");

                entity.HasIndex(e => e.ShortCode)
                    .HasName("UQ__Features__76E6BB82F49A484D")
                    .IsUnique();

                entity.Property(e => e.FeatureName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ShortCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FirstDemoInteraction>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DemoIsWith).IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.NumberOfCaregiver)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfClient)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfEmployee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfNurse)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProspectUuid)
                    .HasColumnName("ProspectUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Solutions).IsUnicode(false);

                entity.Property(e => e.SolutionsAmountPaid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StateType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<FirstDemoInteractionMappingKeyObjective>(entity =>
            {
                entity.Property(e => e.KeyObjective).IsUnicode(false);
            });

            modelBuilder.Entity<FirstDemoQuestion>(entity =>
            {
                entity.Property(e => e.Question).IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FirstDemoQuestionMappingAnswer>(entity =>
            {
                entity.Property(e => e.Answer).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ProspectUuid)
                    .HasColumnName("ProspectUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<FirstDemoQuestionMappingPayer>(entity =>
            {
                entity.Property(e => e.Payer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Percentage)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<FirstDemoQuestionMappingPriorityAnswer>(entity =>
            {
                entity.Property(e => e.Priority).IsUnicode(false);
            });

            modelBuilder.Entity<Franchise>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FranchiseNameList>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FromEmailForTemplate>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<IgnoreTextList>(entity =>
            {
                entity.Property(e => e.Text)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImportBusinessData>(entity =>
            {
                entity.HasIndex(e => e.ImportedDate)
                    .HasName("IX_ImportBusinessData");

                entity.Property(e => e.AddressLine1).IsUnicode(false);

                entity.Property(e => e.Administrator)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.County).IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .IsUnicode(false);

                entity.Property(e => e.FanCount).IsUnicode(false);

                entity.Property(e => e.Fax).IsUnicode(false);

                entity.Property(e => e.FbAddress).IsUnicode(false);

                entity.Property(e => e.FbEmail).IsUnicode(false);

                entity.Property(e => e.FbPhone).IsUnicode(false);

                entity.Property(e => e.FbPosts).HasColumnType("text");

                entity.Property(e => e.FbStatusCode).IsUnicode(false);

                entity.Property(e => e.FbUrl)
                    .HasColumnName("FbURL")
                    .IsUnicode(false);

                entity.Property(e => e.Hha)
                    .HasColumnName("HHA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImportedDate).HasColumnType("datetime");

                entity.Property(e => e.LastPostTimestamp).IsUnicode(false);

                entity.Property(e => e.MapLocation).IsUnicode(false);

                entity.Property(e => e.MobileNumber).IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.PostalCode).IsUnicode(false);

                entity.Property(e => e.ServiceType).IsUnicode(false);

                entity.Property(e => e.Source).IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);

                entity.Property(e => e.Tags).IsUnicode(false);

                entity.Property(e => e.WebsiteEmail).IsUnicode(false);

                entity.Property(e => e.WebsiteUrl)
                    .HasColumnName("WebsiteURL")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImportBusinessFbPosts>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.BusinessName).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.FanCount).IsUnicode(false);

                entity.Property(e => e.FbAddress).IsUnicode(false);

                entity.Property(e => e.FbEmail).IsUnicode(false);

                entity.Property(e => e.FbPhone).IsUnicode(false);

                entity.Property(e => e.FbPosts).HasColumnType("text");

                entity.Property(e => e.FbStatusCode).IsUnicode(false);

                entity.Property(e => e.FbUrl)
                    .HasColumnName("FbURL")
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ImportedDate).HasColumnType("datetime");

                entity.Property(e => e.LastPostTimestamp).IsUnicode(false);

                entity.Property(e => e.OldFblink)
                    .HasColumnName("OldFBLink")
                    .IsUnicode(false);

                entity.Property(e => e.OldLastFbpost)
                    .HasColumnName("OldLastFBPost")
                    .IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImportWebSiteText>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.BusinessName).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ImportedDate).HasColumnType("datetime");

                entity.Property(e => e.State).IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebText).HasColumnType("text");

                entity.Property(e => e.WebUrl)
                    .HasColumnName("WebURL")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IndeedJobCompanyMappingBusiness>(entity =>
            {
                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IndeedCompName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Json).IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JwtokenVeraMedix>(entity =>
            {
                entity.HasKey(e => e.TokenId)
                    .HasName("PK__JWTokenV__658FEEEA1D3A1BA1");

                entity.ToTable("JWTokenVeraMedix");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserIdEncyptKey)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Jwttoken>(entity =>
            {
                entity.HasKey(e => e.TokenId)
                    .HasName("PK__JWTToken__658FEEEA60142F8D");

                entity.ToTable("JWTToken");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewBusinessFburl>(entity =>
            {
                entity.ToTable("NewBusinessFBUrl");

                entity.Property(e => e.BussinessName).IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FbUrl)
                    .HasColumnName("FbURL")
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NonFranchise>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.PackageId).HasColumnName("packageId");

                entity.Property(e => e.PackageName)
                    .IsRequired()
                    .HasColumnName("packageName")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayerVideo>(entity =>
            {
                entity.Property(e => e.VideoDescripton).IsUnicode(false);

                entity.Property(e => e.VideoTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.YoutubeVideoId)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayerVideoQuestion>(entity =>
            {
                entity.Property(e => e.Answer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OptionOne)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OptionTwo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlayerVideoQuestion1)
                    .HasColumnName("PlayerVideoQuestion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ShowsOn)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayerVideoQuizCongratulationStatus>(entity =>
            {
                entity.HasKey(e => e.PlayerVideoQuizCongratulationId)
                    .HasName("PK__PlayerVi__CDBF3FF195619B21");

                entity.Property(e => e.CaregiverUuid)
                    .HasColumnName("CaregiverUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<PlayerVideoUserDetails>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDuration).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WatchDuration).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.PlayerVideo)
                    .WithMany(p => p.PlayerVideoUserDetails)
                    .HasForeignKey(d => d.PlayerVideoId)
                    .HasConstraintName("FK__PlayerVid__Playe__2CDD9F46");
            });

            modelBuilder.Entity<PlayerVideoUserEvents>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.PausePlayType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.PlayerVideoUserDetails)
                    .WithMany(p => p.PlayerVideoUserEvents)
                    .HasForeignKey(d => d.PlayerVideoUserDetailsId)
                    .HasConstraintName("FK__PlayerVid__Playe__2DD1C37F");
            });

            modelBuilder.Entity<PlayerVideoUserQuestionAnswer>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.PlayerVideoQuestionAnswer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserUuid)
                    .HasColumnName("UserUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProspactNewContact>(entity =>
            {
                entity.HasKey(e => e.Uuid)
                    .HasName("PK__Prospact__65A475E7EED26839");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ahcanumber)
                    .HasColumnName("AHCANumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoClock)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BounceDate).HasColumnType("datetime");

                entity.Property(e => e.BusinessName).IsUnicode(false);

                entity.Property(e => e.BusinessUuid)
                    .HasColumnName("BusinessUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClientLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CmscertificationNumber)
                    .HasColumnName("CMSCertificationNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUrl).IsUnicode(false);

                entity.Property(e => e.ControllingInterest)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateCertified).HasColumnType("datetime");

                entity.Property(e => e.DateOfFirstContact).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedHourPerWeek).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ExpectedValue)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FanCount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FbImgUrl)
                    .HasColumnName("FbImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.Fblink)
                    .HasColumnName("FBLink")
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUp)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Goal).IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("ImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.InactiveReason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsClient)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsLoginCarePlan)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsLoginRelyfyFamily)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lat)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseEffectiveDate).HasColumnType("date");

                entity.Property(e => e.LicenseExpirationDate).HasColumnType("date");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LicensedBeds)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LinkedInImgUrl)
                    .HasColumnName("LinkedInImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.LinkedInProfile).IsUnicode(false);

                entity.Property(e => e.Lng)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddressLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Marketer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Owner)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerSince).HasColumnType("date");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryCaseManager)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileTag)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Referral)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Scheduler)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Stage)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TwiterLink).IsUnicode(false);

                entity.Property(e => e.TwitterImgUrl)
                    .HasColumnName("TwitterImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfOwnership)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UnsubscribeDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebImgUrl)
                    .HasColumnName("WebImgURL")
                    .IsUnicode(false);

                entity.Property(e => e.WebUrl).IsUnicode(false);

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProspactNewContact1>(entity =>
            {
                entity.HasKey(e => e.Uuid)
                    .HasName("PK__Prospact__65A475E7FB9B50FF");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ahcanumber)
                    .HasColumnName("AHCANumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoClock)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName).IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClientLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CmscertificationNumber)
                    .HasColumnName("CMSCertificationNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ControllingInterest)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateCertified).HasColumnType("datetime");

                entity.Property(e => e.DateOfFirstContact).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedHourPerWeek).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ExpectedValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FanCount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fblink)
                    .HasColumnName("FBLink")
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUp)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InactiveReason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsClient)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsLoginCarePlan)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsLoginRelyfyFamily)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseEffectiveDate).HasColumnType("date");

                entity.Property(e => e.LicenseExpirationDate).HasColumnType("date");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LicensedBeds)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddressLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Marketer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Owner)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerSince).HasColumnType("date");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryCaseManager)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileTag)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Referral)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Scheduler)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TwiterLink).IsUnicode(false);

                entity.Property(e => e.TypeOfOwnership)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebUrl).IsUnicode(false);

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProspactNewContactMappingService>(entity =>
            {
                entity.Property(e => e.ProspactUuid)
                    .HasColumnName("ProspactUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProspactNewContactMappingService1>(entity =>
            {
                entity.Property(e => e.ProspactUuid)
                    .HasColumnName("ProspactUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProspactNewContactServices>(entity =>
            {
                entity.Property(e => e.ServiceType)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProspectContactMappingTag>(entity =>
            {
                entity.Property(e => e.ProspectUuid)
                    .HasColumnName("ProspectUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProspectDemoRequest>(entity =>
            {
                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DemoDate)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.RequestBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProspectDemoRequestMappingAnswer>(entity =>
            {
                entity.Property(e => e.Answer).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProspectDemoRequestMappingPriorityAnswer>(entity =>
            {
                entity.Property(e => e.Priority).IsUnicode(false);
            });

            modelBuilder.Entity<ProspectInteraction>(entity =>
            {
                entity.Property(e => e.AgencyUuid)
                    .HasColumnName("AgencyUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfLastCall).HasColumnType("datetime");

                entity.Property(e => e.InteractionType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.OtherContactUuid)
                    .HasColumnName("OtherContactUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProspectUuid)
                    .HasColumnName("ProspectUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Stage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProspectInteractionCopy>(entity =>
            {
                entity.ToTable("ProspectInteraction_copy");

                entity.Property(e => e.AgencyUuid)
                    .HasColumnName("AgencyUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfLastCall).HasColumnType("datetime");

                entity.Property(e => e.InteractionType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.OtherContactUuid)
                    .HasColumnName("OtherContactUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProspectUuid)
                    .HasColumnName("ProspectUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Stage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProspectMailInteraction>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailBody).IsUnicode(false);

                entity.Property(e => e.MailSubject).IsUnicode(false);

                entity.Property(e => e.ProspectUuid)
                    .HasColumnName("ProspectUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SendGridMessageId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProspectMailInteractionCopy>(entity =>
            {
                entity.ToTable("ProspectMailInteraction_copy");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailBody).IsUnicode(false);

                entity.Property(e => e.MailSubject).IsUnicode(false);

                entity.Property(e => e.ProspectUuid)
                    .HasColumnName("ProspectUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SendGridMessageId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProspectOtherContact>(entity =>
            {
                entity.HasKey(e => e.Uuid)
                    .HasName("PK__Prospect__65A475E73CB1A3C9");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfFirstContact).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedHourPerWeek).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ExpectedValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fblink)
                    .HasColumnName("FBLink")
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InactiveReason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.ProfitStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProspectUuid)
                    .HasColumnName("ProspectUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TwiterLink).IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebUrl).IsUnicode(false);

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProspectStatusHistory>(entity =>
            {
                entity.Property(e => e.ProspectUuid)
                    .HasColumnName("ProspectUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProspectView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProspectView");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AutoClock)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName).IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClientLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FanCount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Stage)
                    .HasColumnName("stage")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReferralCompany>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PersonOfContact)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralCompanyUuid)
                    .HasColumnName("ReferralCompanyUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReferralCompanyCaryFyDocument>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ReferralCompanyName).IsUnicode(false);

                entity.Property(e => e.ReferralCompanyUuid)
                    .HasColumnName("ReferralCompanyUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReferralCompanyCaryFyDocumentMappingUrl>(entity =>
            {
                entity.ToTable("ReferralCompanyCaryFyDocumentMappingURL");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReferralSource>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Designation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InactiveReason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralCompanyUuid)
                    .IsRequired()
                    .HasColumnName("ReferralCompanyUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralSourceUuid)
                    .IsRequired()
                    .HasColumnName("ReferralSourceUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RelyFyAgencyAdvanceBilling>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsAdjusted)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Json).IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RefrenceNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseJson).IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<RelyFyAgencyInvoiceBilling>(entity =>
            {
                entity.Property(e => e.ActualDayAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BaseRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreditAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DiscountPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ExtraClientRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FinalTotalAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProratedCredit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.TotalAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<RelyFyAgencyInvoiceBillingFormula>(entity =>
            {
                entity.Property(e => e.BasePrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExtraRatePerClient).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.IsMaximumAmount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaximumAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<RelyFyAgencyInvoiceBillingMailSent>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailBody).IsUnicode(false);

                entity.Property(e => e.MailSubject).IsUnicode(false);

                entity.Property(e => e.SendGridMessageId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<RelyFyAgencyInvoicePayment>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Json).IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RefrenceNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseJson).IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<RelyFyFeedbackResponse>(entity =>
            {
                entity.Property(e => e.Action)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FeedbackBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RelyFyFeedbackResponseMappingCall>(entity =>
            {
                entity.Property(e => e.CallSid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<RelyFyFeedbackResponseMappingMail>(entity =>
            {
                entity.Property(e => e.Attachments).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailBody).IsUnicode(false);

                entity.Property(e => e.MailSubject).IsUnicode(false);

                entity.Property(e => e.SendGridMessageId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<RelyfyCustomerInformation>(entity =>
            {
                entity.HasIndex(e => new { e.EmailId, e.Type })
                    .HasName("UQ__ClientCo__7ED91ACEDFD3AD57")
                    .IsUnique();

                entity.Property(e => e.ActivationDate).HasColumnType("datetime");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BounceDate).HasColumnType("datetime");

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientIdentifier)
                    .HasColumnName("Client_Identifier ")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Credentials)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DbtimeZone)
                    .HasColumnName("DBTimeZone")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FacebookLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InBusinessSince)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceUniqueId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsVeraMedix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsVeraNutri)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LogoImage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordSalt)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PracticeName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProspectUuid)
                    .HasColumnName("ProspectUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuickBookCompanyId).IsUnicode(false);

                entity.Property(e => e.QuickBookToken).IsUnicode(false);

                entity.Property(e => e.QuickbooksClientId).IsUnicode(false);

                entity.Property(e => e.QuickbooksClientSecret).IsUnicode(false);

                entity.Property(e => e.ReferralUuid)
                    .HasColumnName("ReferralUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Registration)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SageCompanyId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SkypeId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TwitterLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnsubscribeDate).HasColumnType("datetime");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VaultId)
                    .HasColumnName("VaultID")
                    .IsUnicode(false);

                entity.Property(e => e.VaultKey)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReplaceKeyWord>(entity =>
            {
                entity.Property(e => e.ReplaceText)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.Property(e => e.RolesName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SecondDemoInteraction>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.ProspectUuid)
                    .HasColumnName("ProspectUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<SecondDemoInteractionMeppingSteps>(entity =>
            {
                entity.Property(e => e.Step)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SecondDemoQuestion>(entity =>
            {
                entity.Property(e => e.Question).IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SecondDemoQuestionMappingAnswer>(entity =>
            {
                entity.Property(e => e.Answer).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<SendGridMailReply>(entity =>
            {
                entity.Property(e => e.Attachments).IsUnicode(false);

                entity.Property(e => e.Body).IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Data).IsUnicode(false);

                entity.Property(e => e.FromEmail).IsUnicode(false);

                entity.Property(e => e.Html)
                    .HasColumnName("HTML")
                    .IsUnicode(false);

                entity.Property(e => e.JsonList).IsUnicode(false);

                entity.Property(e => e.Subject).IsUnicode(false);

                entity.Property(e => e.ToEmail).IsUnicode(false);
            });

            modelBuilder.Entity<SendGridWebhookResponse>(entity =>
            {
                entity.HasIndex(e => e.Event)
                    .HasName("Event_Idx");

                entity.HasIndex(e => e.MailInteractionId)
                    .HasName("MailInteractionId_Idx");

                entity.HasIndex(e => e.Type)
                    .HasName("Type_Idx");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Event)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MessageId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseJson).IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Specialization>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SpecializationCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SpecializationName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StateCountyData>(entity =>
            {
                entity.HasIndex(e => e.CountyName)
                    .HasName("CountyName_Idx");

                entity.HasIndex(e => e.StateCode)
                    .HasName("State_Idx");

                entity.Property(e => e.CountyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CountyName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StatePropertyForEvvInfo>(entity =>
            {
                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastDateUpdated).HasColumnType("date");

                entity.Property(e => e.Link).IsUnicode(false);

                entity.Property(e => e.MandateDate)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MandateModel).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.ReferralCompanyUuid)
                    .HasColumnName("ReferralCompanyUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedVendor).IsUnicode(false);

                entity.Property(e => e.SellingTips).IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StateNotes).IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("student");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Fname)
                    .HasColumnName("fname")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasColumnName("lname")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentAddress>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentAddress)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__StudentAd__Stude__200DB40D");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeeUuid)
                    .HasColumnName("EmployeeUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Task1)
                    .HasColumnName("Task")
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaskHistory>(entity =>
            {
                entity.Property(e => e.Json).IsUnicode(false);
            });

            modelBuilder.Entity<TempExeImport>(entity =>
            {
                entity.ToTable("tempExeImport");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Agency)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempExeImportCounty>(entity =>
            {
                entity.ToTable("tempExeImportCounty");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Agency).HasMaxLength(255);

                entity.Property(e => e.County).HasMaxLength(255);

                entity.Property(e => e.DmaDchProviderId)
                    .HasColumnName("DMA#/DCH Provider ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);
            });

            modelBuilder.Entity<TempFbpost>(entity =>
            {
                entity.ToTable("TempFBPost");

                entity.Property(e => e.Json)
                    .HasColumnName("JSON")
                    .IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestExcelImport>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LinkedClicked)
                    .HasColumnName("Linked Clicked")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MergeStatus)
                    .HasColumnName("Merge status")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TwilioRecordingForProspect>(entity =>
            {
                entity.Property(e => e.AccountSid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ApiVersion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationSid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CallDate).HasColumnType("datetime");

                entity.Property(e => e.CallDuration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CallSid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CallStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CallbackSource)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Caller)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Client)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Direction)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProspectUuid)
                    .HasColumnName("ProspectUUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserQuestionForSponsor>(entity =>
            {
                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Question).IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZipCode>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.CountyName)
                    .HasName("County_Idx");

                entity.HasIndex(e => e.State)
                    .HasName("State_Idx");

                entity.HasIndex(e => new { e.CountyName, e.Zip })
                    .HasName("nci_wi_ZipCode_CCFA203AC5260406FE169213055B891D");

                entity.Property(e => e.Classfp)
                    .HasColumnName("CLASSFP")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CountyName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Stcountyfp)
                    .HasColumnName("STCOUNTYFP")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserNotes>(entity =>
            {

                entity.Property(e => e.Id);
                entity.Property(e => e.UUID).IsUnicode(false);
                entity.Property(e => e.LoginUUID).IsUnicode(false);
                entity.Property(e => e.UserUUID).IsUnicode(false);
                entity.Property(e => e.Type).IsUnicode(false);
                entity.Property(e => e.Notes).IsUnicode(false);
                entity.Property(e => e.IsActive).IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.HasSequence("hibernate_sequence");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
