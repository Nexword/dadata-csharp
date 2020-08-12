﻿using System.Collections.Specialized;
using Dadata.Model;

namespace Dadata
{
    public class SuggestClientSync : ClientBaseSync, ISuggestClientSync
    {
        protected const string BASE_URL = "https://suggestions.dadata.ru/suggestions/api/4_1/rs";

        public SuggestClientSync(string token, string baseUrl = BASE_URL) : base(token, baseUrl) { }

        #region Address

        public SuggestResponse<Address> SuggestAddress(string query, int count = 5)
        {
            var request = new SuggestAddressRequest(query, count);
            return SuggestAddress(request);
        }

        public SuggestResponse<Address> SuggestAddress(SuggestAddressRequest request)
        {
            return Execute<SuggestResponse<Address>>(method: SuggestionsMethod.Suggest, entity: SuggestionsEntity.Address, request: request);
        }

        public SuggestResponse<Address> FindAddress(string query)
        {
            var request = new FindAddressRequest(query);
            return FindAddress(request);
        }

        public SuggestResponse<Address> FindAddress(FindAddressRequest request)
        {
            return Execute<SuggestResponse<Address>>(method: SuggestionsMethod.Find, entity: SuggestionsEntity.Address, request: request);
        }

        public SuggestResponse<Address> Geolocate(double lat, double lon, int radius_meters = 100, int count = 5)
        {
            var request = new GeolocateRequest(lat, lon, radius_meters, count);
            return Geolocate(request);
        }

        public SuggestResponse<Address> Geolocate(GeolocateRequest request)
        {
            return Execute<SuggestResponse<Address>>(method: SuggestionsMethod.Geolocate, entity: SuggestionsEntity.Address, request: request);
        }

        public IplocateResponse Iplocate(string ip, string language = "ru")
        {
            var parameters = new NameValueCollection();
            parameters.Add("ip", ip);
            parameters.Add("language", language);
            return ExecuteGet<IplocateResponse>(method: SuggestionsMethod.Iplocate, entity: SuggestionsEntity.Address, parameters: parameters);
        }

        #endregion

        #region Bank

        public SuggestResponse<Bank> SuggestBank(string query, int count = 5)
        {
            var request = new SuggestBankRequest(query, count);
            return SuggestBank(request);
        }

        public SuggestResponse<Bank> SuggestBank(SuggestBankRequest request)
        {
            return Execute<SuggestResponse<Bank>>(method: SuggestionsMethod.Suggest, entity: SuggestionsEntity.Bank, request: request);
        }

        public SuggestResponse<Bank> FindBank(string query)
        {
            var request = new FindBankRequest(query);
            return FindBank(request);
        }

        public SuggestResponse<Bank> FindBank(FindBankRequest request)
        {
            return Execute<SuggestResponse<Bank>>(method: SuggestionsMethod.Find, entity: SuggestionsEntity.Bank, request: request);
        }

        #endregion

        #region Email

        public SuggestResponse<Email> SuggestEmail(string query, int count = 5)
        {
            var request = new SuggestRequest(query, count);
            return SuggestEmail(request);
        }

        public SuggestResponse<Email> SuggestEmail(SuggestRequest request)
        {
            return Execute<SuggestResponse<Email>>(method: SuggestionsMethod.Suggest, entity: SuggestionsEntity.Email, request: request);
        }

        #endregion

        #region Fias

        public SuggestResponse<FiasAddress> SuggestFias(string query, int count = 5)
        {
            var request = new SuggestAddressRequest(query, count);
            return SuggestFias(request);
        }

        public SuggestResponse<FiasAddress> SuggestFias(SuggestAddressRequest request)
        {
            return Execute<SuggestResponse<FiasAddress>>(method: SuggestionsMethod.Suggest, entity: SuggestionsEntity.Fias, request: request);
        }

        public SuggestResponse<Address> FindFias(string query)
        {
            var request = new SuggestRequest(query);
            return FindFias(request);
        }

        public SuggestResponse<Address> FindFias(SuggestRequest request)
        {
            return Execute<SuggestResponse<Address>>(method: SuggestionsMethod.Find, entity: SuggestionsEntity.Fias, request: request);
        }

        #endregion

        #region Name

        public SuggestResponse<Fullname> SuggestName(string query, int count = 5)
        {
            var request = new SuggestNameRequest(query, count);
            return SuggestName(request);
        }

        public SuggestResponse<Fullname> SuggestName(SuggestNameRequest request)
        {
            return Execute<SuggestResponse<Fullname>>(method: SuggestionsMethod.Suggest, entity: SuggestionsEntity.Name, request: request);
        }

        #endregion

        #region Party

        public SuggestResponse<Party> SuggestParty(string query, int count = 5)
        {
            var request = new SuggestPartyRequest(query, count);
            return SuggestParty(request);
        }

        public SuggestResponse<Party> SuggestParty(SuggestPartyRequest request)
        {
            return Execute<SuggestResponse<Party>>(method: SuggestionsMethod.Suggest, entity: SuggestionsEntity.Party, request: request);
        }

        public SuggestResponse<Party> FindParty(string query)
        {
            var request = new FindPartyRequest(query);
            return FindParty(request);
        }

        public SuggestResponse<Party> FindParty(FindPartyRequest request)
        {
            return Execute<SuggestResponse<Party>>(method: SuggestionsMethod.Find, entity: SuggestionsEntity.Party, request: request);
        }

        public SuggestResponse<Party> FindAffiliated(string query)
        {
            var request = new FindAffiliatedRequest(query);
            return FindAffiliated(request);
        }

        public SuggestResponse<Party> FindAffiliated(FindAffiliatedRequest request)
        {
            return Execute<SuggestResponse<Party>>(method: SuggestionsMethod.FindAffiliated, entity: SuggestionsEntity.Party, request: request);
        }

        #endregion
    }
}
