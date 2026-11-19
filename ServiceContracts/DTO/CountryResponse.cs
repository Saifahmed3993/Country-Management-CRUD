using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace ServiceContracts.DTO
{
    /// <summary>
    /// DTO Class Is Used To return type for the most of CountryService Methods
    /// </summary>
    public class CountryResponse
    {
        public Guid CountryID { get; set; }
        public string? CountryName { get; set; }
    }
    public static class CountryExtentions
    {
        public static CountryResponse ToCountryResponse(this Country country)
        {
            return new CountryResponse()
            {
                CountryID = country.CountryID,
                CountryName = country.CountryName
            };
        }
    }
}