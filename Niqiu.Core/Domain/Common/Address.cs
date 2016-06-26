﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Niqiu.Core.Domain.Common
{
    public class Address : BaseEntity, ICloneable
    {
        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the company
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Gets or sets the country identifier
        /// </summary>
        public int? CountryId { get; set; }

        /// <summary>
        /// Gets or sets the state/province identifier
        /// </summary>
        public int? StateProvinceId { get; set; }
        

        /// <summary>
        /// Gets or sets the address 1
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the address 2
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the zip/postal code
        /// </summary>
        public string ZipPostalCode { get; set; }

        /// <summary>
        /// Gets or sets the phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the fax number
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// Gets or sets the custom attributes (see "AddressAttribute" entity for more info)
        /// </summary>
        public string CustomAttributes { get; set; }

        /// <summary>
        /// 是否是默认地址
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or sets the state/province
        /// </summary>
        public virtual Province Province { get; set; }
        public virtual City City { get; set; }
        public virtual District District { get; set; }

        public object Clone()
        {
            var addr = new Address
            {
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                Company = Company,
                CountryId = CountryId,
                StateProvinceId = StateProvinceId,
                Address1 = Address1,
                Address2 = Address2,
                ZipPostalCode = ZipPostalCode,
                PhoneNumber = PhoneNumber,
                FaxNumber = FaxNumber,
                CustomAttributes = CustomAttributes,
                IsDefault = IsDefault,
                Province = Province,
                City = City,
                District = District
            };
            return addr;
        }
    }

    [Table("S_Province")]
    public class Province
    {
       [Key]
        public int ProvinceID { get; set; }
        public string ProvinceName { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
    }

    [Table("S_City")]
    public class City
    {
       [Key]
        public int CityID { get; set; }

        public string CityName { get; set; }

        public string ZipCode { get; set; }

        public int ProvinceID { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

    }


    [Table("S_District")]
    public class District
    {
        public int DistrictID { get; set; }

        public string DistrictName { get; set; }

        public string CityID { get; set; }


        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}
