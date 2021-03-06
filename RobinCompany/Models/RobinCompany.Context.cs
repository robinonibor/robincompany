﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RobinCompany.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RobinCompanyEntities : DbContext
    {
        public RobinCompanyEntities()
            : base("name=RobinCompanyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
    
        public virtual int uspDeleteCompany(Nullable<long> companyID)
        {
            var companyIDParameter = companyID.HasValue ?
                new ObjectParameter("CompanyID", companyID) :
                new ObjectParameter("CompanyID", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspDeleteCompany", companyIDParameter);
        }
    
        public virtual int uspDeleteContact(Nullable<long> contactId)
        {
            var contactIdParameter = contactId.HasValue ?
                new ObjectParameter("ContactId", contactId) :
                new ObjectParameter("ContactId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspDeleteContact", contactIdParameter);
        }
    
        public virtual int uspDeleteContract(Nullable<long> contractId)
        {
            var contractIdParameter = contractId.HasValue ?
                new ObjectParameter("ContractId", contractId) :
                new ObjectParameter("ContractId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspDeleteContract", contractIdParameter);
        }
    
        public virtual int uspInsertCompany(string companyName, string companyDescription, string companyABNCAN, string companyWebsite)
        {
            var companyNameParameter = companyName != null ?
                new ObjectParameter("CompanyName", companyName) :
                new ObjectParameter("CompanyName", typeof(string));
    
            var companyDescriptionParameter = companyDescription != null ?
                new ObjectParameter("CompanyDescription", companyDescription) :
                new ObjectParameter("CompanyDescription", typeof(string));
    
            var companyABNCANParameter = companyABNCAN != null ?
                new ObjectParameter("CompanyABNCAN", companyABNCAN) :
                new ObjectParameter("CompanyABNCAN", typeof(string));
    
            var companyWebsiteParameter = companyWebsite != null ?
                new ObjectParameter("CompanyWebsite", companyWebsite) :
                new ObjectParameter("CompanyWebsite", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspInsertCompany", companyNameParameter, companyDescriptionParameter, companyABNCANParameter, companyWebsiteParameter);
        }
    
        public virtual int uspInsertContact(Nullable<long> contactTitleID, string contactFirstName, string contactLastName, string contactType, string email, string phoneNumber, string department, Nullable<bool> aCTIVE)
        {
            var contactTitleIDParameter = contactTitleID.HasValue ?
                new ObjectParameter("ContactTitleID", contactTitleID) :
                new ObjectParameter("ContactTitleID", typeof(long));
    
            var contactFirstNameParameter = contactFirstName != null ?
                new ObjectParameter("ContactFirstName", contactFirstName) :
                new ObjectParameter("ContactFirstName", typeof(string));
    
            var contactLastNameParameter = contactLastName != null ?
                new ObjectParameter("ContactLastName", contactLastName) :
                new ObjectParameter("ContactLastName", typeof(string));
    
            var contactTypeParameter = contactType != null ?
                new ObjectParameter("ContactType", contactType) :
                new ObjectParameter("ContactType", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var departmentParameter = department != null ?
                new ObjectParameter("Department", department) :
                new ObjectParameter("Department", typeof(string));
    
            var aCTIVEParameter = aCTIVE.HasValue ?
                new ObjectParameter("ACTIVE", aCTIVE) :
                new ObjectParameter("ACTIVE", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspInsertContact", contactTitleIDParameter, contactFirstNameParameter, contactLastNameParameter, contactTypeParameter, emailParameter, phoneNumberParameter, departmentParameter, aCTIVEParameter);
        }
    
        public virtual int uspInsertContract(string contractType, Nullable<System.DateTime> contractSignedDate, Nullable<System.DateTime> contractEndDate, Nullable<System.DateTime> contractRenewalDate, Nullable<long> price)
        {
            var contractTypeParameter = contractType != null ?
                new ObjectParameter("ContractType", contractType) :
                new ObjectParameter("ContractType", typeof(string));
    
            var contractSignedDateParameter = contractSignedDate.HasValue ?
                new ObjectParameter("ContractSignedDate", contractSignedDate) :
                new ObjectParameter("ContractSignedDate", typeof(System.DateTime));
    
            var contractEndDateParameter = contractEndDate.HasValue ?
                new ObjectParameter("ContractEndDate", contractEndDate) :
                new ObjectParameter("ContractEndDate", typeof(System.DateTime));
    
            var contractRenewalDateParameter = contractRenewalDate.HasValue ?
                new ObjectParameter("ContractRenewalDate", contractRenewalDate) :
                new ObjectParameter("ContractRenewalDate", typeof(System.DateTime));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspInsertContract", contractTypeParameter, contractSignedDateParameter, contractEndDateParameter, contractRenewalDateParameter, priceParameter);
        }
    
        public virtual int uspUpdateCompany(string companyName, string companyDescription, string companyABNCAN, string companyWebsite, Nullable<long> companyID)
        {
            var companyNameParameter = companyName != null ?
                new ObjectParameter("CompanyName", companyName) :
                new ObjectParameter("CompanyName", typeof(string));
    
            var companyDescriptionParameter = companyDescription != null ?
                new ObjectParameter("CompanyDescription", companyDescription) :
                new ObjectParameter("CompanyDescription", typeof(string));
    
            var companyABNCANParameter = companyABNCAN != null ?
                new ObjectParameter("CompanyABNCAN", companyABNCAN) :
                new ObjectParameter("CompanyABNCAN", typeof(string));
    
            var companyWebsiteParameter = companyWebsite != null ?
                new ObjectParameter("CompanyWebsite", companyWebsite) :
                new ObjectParameter("CompanyWebsite", typeof(string));
    
            var companyIDParameter = companyID.HasValue ?
                new ObjectParameter("CompanyID", companyID) :
                new ObjectParameter("CompanyID", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspUpdateCompany", companyNameParameter, companyDescriptionParameter, companyABNCANParameter, companyWebsiteParameter, companyIDParameter);
        }
    
        public virtual int uspUpdateContacts(Nullable<long> contactId, Nullable<long> contactTitleID, string contactFirstName, string contactLastName, string contactType, string email, string phoneNumber, string department, Nullable<bool> aCTIVE)
        {
            var contactIdParameter = contactId.HasValue ?
                new ObjectParameter("ContactId", contactId) :
                new ObjectParameter("ContactId", typeof(long));
    
            var contactTitleIDParameter = contactTitleID.HasValue ?
                new ObjectParameter("ContactTitleID", contactTitleID) :
                new ObjectParameter("ContactTitleID", typeof(long));
    
            var contactFirstNameParameter = contactFirstName != null ?
                new ObjectParameter("ContactFirstName", contactFirstName) :
                new ObjectParameter("ContactFirstName", typeof(string));
    
            var contactLastNameParameter = contactLastName != null ?
                new ObjectParameter("ContactLastName", contactLastName) :
                new ObjectParameter("ContactLastName", typeof(string));
    
            var contactTypeParameter = contactType != null ?
                new ObjectParameter("ContactType", contactType) :
                new ObjectParameter("ContactType", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var departmentParameter = department != null ?
                new ObjectParameter("Department", department) :
                new ObjectParameter("Department", typeof(string));
    
            var aCTIVEParameter = aCTIVE.HasValue ?
                new ObjectParameter("ACTIVE", aCTIVE) :
                new ObjectParameter("ACTIVE", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspUpdateContacts", contactIdParameter, contactTitleIDParameter, contactFirstNameParameter, contactLastNameParameter, contactTypeParameter, emailParameter, phoneNumberParameter, departmentParameter, aCTIVEParameter);
        }
    
        public virtual int uspUpdateContract(Nullable<long> contractId, string contractType, Nullable<System.DateTime> contractStartDate, Nullable<System.DateTime> contractEndDate, Nullable<System.DateTime> contractRenewalDate, Nullable<long> contractPrice)
        {
            var contractIdParameter = contractId.HasValue ?
                new ObjectParameter("ContractId", contractId) :
                new ObjectParameter("ContractId", typeof(long));
    
            var contractTypeParameter = contractType != null ?
                new ObjectParameter("ContractType", contractType) :
                new ObjectParameter("ContractType", typeof(string));
    
            var contractStartDateParameter = contractStartDate.HasValue ?
                new ObjectParameter("ContractStartDate", contractStartDate) :
                new ObjectParameter("ContractStartDate", typeof(System.DateTime));
    
            var contractEndDateParameter = contractEndDate.HasValue ?
                new ObjectParameter("ContractEndDate", contractEndDate) :
                new ObjectParameter("ContractEndDate", typeof(System.DateTime));
    
            var contractRenewalDateParameter = contractRenewalDate.HasValue ?
                new ObjectParameter("ContractRenewalDate", contractRenewalDate) :
                new ObjectParameter("ContractRenewalDate", typeof(System.DateTime));
    
            var contractPriceParameter = contractPrice.HasValue ?
                new ObjectParameter("ContractPrice", contractPrice) :
                new ObjectParameter("ContractPrice", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspUpdateContract", contractIdParameter, contractTypeParameter, contractStartDateParameter, contractEndDateParameter, contractRenewalDateParameter, contractPriceParameter);
        }
    }
}
