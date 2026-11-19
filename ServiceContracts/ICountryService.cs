using ServiceContracts.DTO;

namespace ServiceContracts
{
    /// <summary>
    /// Represent business logic for mainpulating Country Entity
    /// </summary>
    public interface ICountryService
    {
        /// <summary>
        /// Adds a country obj to the list of countries
        /// </summary>
        /// <param name="countryAddRequest"></param>
        /// <returns>
        /// Returns the response object containing the details of the added country with id
        /// </returns>
        CountryResponse AddCountry(CountryAddRequest? countryAddRequest);
    }
}
