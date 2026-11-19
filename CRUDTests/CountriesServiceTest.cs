using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Text;
using Services;
using ServiceContracts.DTO;
namespace CRUDTests
{
    public class CountriesServiceTest
    {
        private readonly ICountryService _countryService; 
        public CountriesServiceTest()
        {
            _countryService = new CountriesService();
        }

        //first case
        //when countryAddRequest is Null , Should throw ArgumentNullException
        [Fact]
        public void AddCountry_NullCountry()
        {
            //Arrange
            CountryAddRequest? request = null;

            //Assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                //Act
                _countryService.AddCountry(request);
            });

        }

        //second case
        //when country name is null or empty, should throw ArgumentException

        [Fact]
        public void AddCountry_CountryNameIsNull()
        {
            //Arrange
            CountryAddRequest? request = new CountryAddRequest() { CountryName = null};

            //Assert
            Assert.Throws<ArgumentException>(() =>
            {
                //Act
                _countryService.AddCountry(request);
            });

        }


        //third case
        //when the country name is dubplicate, should throw ArgumentException
        [Fact]
        public void AddCountry_DuplicateCountryName()
        {
            //Arrange
            CountryAddRequest? request1 = new CountryAddRequest() { CountryName = "Egypt" };
            CountryAddRequest? request2 = new CountryAddRequest() { CountryName = "Egypt" };

            //Assert
            Assert.Throws<ArgumentException>(() =>
            {
                //Act
                _countryService.AddCountry(request1);
                _countryService.AddCountry(request2);

            });

        }



        //fourth case
        //when you supply proper country name, it should insert(Add)
        //the country and return the country object with the country id

        [Fact]
        public void AddCountry_ProperCountryDetails()
        {
            //Arrange
            CountryAddRequest? request = new CountryAddRequest() { CountryName = "UK" };
            
            //Act
            CountryResponse response = _countryService.AddCountry(request);

            //Assert
            Assert.True(response.CountryID != Guid.Empty);

        }

    }
}
