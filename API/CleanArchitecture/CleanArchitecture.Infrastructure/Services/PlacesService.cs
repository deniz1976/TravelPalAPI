using CleanArchitecture.Core.Entities.TravelEntities;
using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Features.TravelRoute.Queries.RouteComponentImage;
using CleanArchitecture.Core.Mappings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Core.Interfaces.Repositories;
using AutoMapper.Configuration;
using CleanArchitecture.Core.Interfaces.Route;

namespace CleanArchitecture.Infrastructure.Services
{
    public class PlacesService : IPlacesService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _apiUrl;
        private readonly string _imageApiUrl;
        private readonly IRouteReadRepository _routeReadRepository;
        private readonly IRouteWriteRepository _routeWriteRepository;

        public PlacesService(HttpClient httpClient,IRouteWriteRepository routeWriteRepository,IRouteReadRepository routeReadRepository)
        {
            _routeReadRepository = routeReadRepository;
            _routeWriteRepository = routeWriteRepository;
            _httpClient = httpClient;
            _apiKey = "";
            _apiUrl = "https://places.googleapis.com/v1/places:searchText";
            _imageApiUrl = "https://places.googleapis.com/v1/";
            _routeWriteRepository = routeWriteRepository;
            //_configuration = configuration;

        }

        public async Task<List<Breakfast>> BreakfastFinder(PRICE_LEVEL _PRICE_LEVEL, string city, int days)
        {
            string queryString = "";
            if (_PRICE_LEVEL == PRICE_LEVEL.PRICE_LEVEL_INEXPENSIVE)
            {
                queryString = "cheap breakfast in " + city;

            }

            else if (_PRICE_LEVEL == PRICE_LEVEL.PRICE_LEVEL_MODERATE)
            {
                queryString = "moderate breakfast in " + city;
            }

            else if (_PRICE_LEVEL == PRICE_LEVEL.PRICE_LEVEL_EXPENSIVE)
            {
                queryString = "expensive breakfast in " + city;
            }

            else
            {
                throw new Exception("Invalid price level");
            }


            var request = new
            {
                textQuery = queryString
            };

            string jsonRequest = JsonConvert.SerializeObject(request);

            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(_apiUrl),
                Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json")
            };

            httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
            httpRequest.Headers.Add("X-Goog-FieldMask", "places/id");



            HttpResponseMessage response = await _httpClient.SendAsync(httpRequest);


            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            var places = JsonConvert.DeserializeObject<BreakfastResponseList>(responseBody);

            List<Breakfast> breakfasts = new List<Breakfast>();
            if (places != null && places.places != null && places.places.Count != 0)
            {
                foreach (var place in places.places)
                {
                    breakfasts.Add(new Breakfast { googleId = place.id });
                }
            }
            else throw new ApiException("please use different city");

            breakfasts = breakfasts.OrderBy(x => Random.Shared.Next()).ToList();
            var diff = breakfasts.Count - days;
            if (diff <= 0) diff = breakfasts.Count;
            for (int i = 0; i < diff + 1; i++)
            {
                if (breakfasts.Count > days)
                    breakfasts.RemoveAt(breakfasts.Count - 1);
                else
                    break;
            }

            if (breakfasts.Count < days)
            {
                for (int i = 0; i < days - breakfasts.Count; i++)
                {
                    breakfasts.Add((Breakfast)breakfasts[i]);
                }
            }

            for (int i = 0; i < days; i++)
            {
                breakfasts[i] = await GetBreakfastDetails(breakfasts[i].googleId, _PRICE_LEVEL);

            }


            return breakfasts;

        }

        public async Task<Breakfast> GetBreakfastDetails(string googleId, PRICE_LEVEL pricelevel)
        {
            var detailedUrl = $"https://places.googleapis.com/v1/places/{googleId}";
            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(detailedUrl)
            };

            httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
            httpRequest.Headers.Add("X-Goog-FieldMask", "nationalPhoneNumber,formattedAddress,googleMapsUri,websiteUri,location,rating,regularOpeningHours,priceLevel,displayName,reservable,servesBeer,servesWine,servesBrunch,servesVegetarianFood,shortFormattedAddress,outdoorSeating,liveMusic,menuForChildren,restroom,goodForGroups,paymentOptions,primaryType,photos");

            HttpResponseMessage response = await _httpClient.SendAsync(httpRequest);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            var detailedPlace = JsonConvert.DeserializeObject<BreakfastDetailsResponse>(responseBody);

            if (detailedPlace == null) throw new Exception("Failed to retrieve place details");

            var breakfast = new Breakfast
            {
                googleId = googleId,
                nationalPhoneNumber = detailedPlace.nationalPhoneNumber,
                formattedAddress = detailedPlace.formattedAddress,
                googleMapsUri = detailedPlace.googleMapsUri,
                websiteUri = detailedPlace.websiteUri,
                Location = detailedPlace.location,
                rating = detailedPlace.rating,
                RegularOpeningHours = detailedPlace.regularOpeningHours,
                displayName = detailedPlace.displayName,
                reservable = detailedPlace.reservable,
                servesBrunch = detailedPlace.servesBrunch,
                servesVegetarianFood = detailedPlace.servesVegetarianFood,
                shortFormattedAddress = detailedPlace.shortFormattedAddress,
                outdoorSeating = detailedPlace.outdoorSeating,
                liveMusic = detailedPlace.liveMusic,
                menuForChildren = detailedPlace.menuForChildren,
                restroom = detailedPlace.restroom,
                goodForGroups = detailedPlace.goodForGroups,
                paymentOptions = detailedPlace.paymentOptions,
                primaryType = detailedPlace.primaryType,
                photos = detailedPlace.photos,
                _PRICE_LEVEL = pricelevel

            };

            return breakfast;
        }

        public async Task<List<Lunch>> LunchFinder(PRICE_LEVEL _PRICE_LEVEL, string city, int days)
        {
            string queryString = "";
            if (_PRICE_LEVEL == PRICE_LEVEL.PRICE_LEVEL_INEXPENSIVE)
            {
                queryString = "cheap lunch in " + city;

            }

            else if (_PRICE_LEVEL == PRICE_LEVEL.PRICE_LEVEL_MODERATE)
            {
                queryString = "moderate lunch in " + city;
            }

            else if (_PRICE_LEVEL == PRICE_LEVEL.PRICE_LEVEL_EXPENSIVE)
            {
                queryString = "expensive lunch in " + city;
            }

            else
            {
                throw new Exception("Invalid price level");
            }


            var request = new
            {
                textQuery = queryString
            };

            string jsonRequest = JsonConvert.SerializeObject(request);

            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(_apiUrl),
                Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json")
            };

            httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
            httpRequest.Headers.Add("X-Goog-FieldMask", "places/id");



            HttpResponseMessage response = await _httpClient.SendAsync(httpRequest);


            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            var places = JsonConvert.DeserializeObject<LunchResponseList>(responseBody);

            List<Lunch> lunches = new List<Lunch>();
            if (places != null && places.places != null && places.places.Count != 0)
            {
                foreach (var place in places.places)
                {
                    lunches.Add(new Lunch { googleId = place.id });
                }
            }
            else { throw new ApiException("please use different city"); }

            lunches = lunches.OrderBy(x => Random.Shared.Next()).ToList();
            var diff = lunches.Count - days;
            if (diff <= 0) diff = lunches.Count;
            for (int i = 0; i < diff + 1; i++)
            {
                if (lunches.Count > days)
                    lunches.RemoveAt(lunches.Count - 1);
                else
                    break;
            }

            if (lunches.Count < days)
            {
                for (int i = 0; i < days - lunches.Count; i++)
                {
                    lunches.Add((Lunch)lunches[i]);
                }
            }

            for (int i = 0; i < days; i++)
            {
                lunches[i] = await GetLunchDetails(lunches[i].googleId, _PRICE_LEVEL);

            }

            return lunches;

        }

        public async Task<Lunch> GetLunchDetails(string googleId, PRICE_LEVEL pricelevel)
        {
            var detailedUrl = $"https://places.googleapis.com/v1/places/{googleId}";
            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(detailedUrl)
            };

            httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
            httpRequest.Headers.Add("X-Goog-FieldMask", "nationalPhoneNumber,formattedAddress,googleMapsUri,websiteUri,location,rating,regularOpeningHours,priceLevel,displayName,reservable,servesBeer,servesWine,servesBrunch,servesVegetarianFood,shortFormattedAddress,outdoorSeating,liveMusic,menuForChildren,restroom,goodForGroups,paymentOptions,primaryType,photos");

            HttpResponseMessage response = await _httpClient.SendAsync(httpRequest);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            var detailedPlace = JsonConvert.DeserializeObject<LunchDetailsResponse>(responseBody);

            if (detailedPlace == null) throw new Exception("Failed to retrieve place details");

            var lunch = new Lunch
            {
                googleId = googleId,
                nationalPhoneNumber = detailedPlace.nationalPhoneNumber,
                formattedAddress = detailedPlace.formattedAddress,
                googleMapsUri = detailedPlace.googleMapsUri,
                websiteUri = detailedPlace.websiteUri,
                Location = detailedPlace.location,
                rating = detailedPlace.rating,
                RegularOpeningHours = detailedPlace.regularOpeningHours,
                displayName = detailedPlace.displayName,
                reservable = detailedPlace.reservable,
                servesBrunch = detailedPlace.servesBrunch,
                servesVegetarianFood = detailedPlace.servesVegetarianFood,
                shortFormattedAddress = detailedPlace.shortFormattedAddress,
                outdoorSeating = detailedPlace.outdoorSeating,
                liveMusic = detailedPlace.liveMusic,
                menuForChildren = detailedPlace.menuForChildren,
                restroom = detailedPlace.restroom,
                goodForGroups = detailedPlace.goodForGroups,
                paymentOptions = detailedPlace.paymentOptions,
                primaryType = detailedPlace.primaryType,
                photos = detailedPlace.photos,
                servesWine = detailedPlace.servesWine,
                servesBeer = detailedPlace.servesBeer,
                _PRICE_LEVEL = pricelevel
            };

            return lunch;

        }

        public async Task<List<Dinner>> DinnerFinder(PRICE_LEVEL _PRICE_LEVEL, string city, int days)
        {
            string queryString = "";
            if (_PRICE_LEVEL == PRICE_LEVEL.PRICE_LEVEL_INEXPENSIVE)
            {
                queryString = "cheap dinner in " + city;

            }

            else if (_PRICE_LEVEL == PRICE_LEVEL.PRICE_LEVEL_MODERATE)
            {
                queryString = "moderate dinner in " + city;
            }

            else if (_PRICE_LEVEL == PRICE_LEVEL.PRICE_LEVEL_EXPENSIVE)
            {
                queryString = "expensive dinner in " + city;
            }

            else
            {
                throw new Exception("Invalid price level");
            }


            var request = new
            {
                textQuery = queryString
            };

            string jsonRequest = JsonConvert.SerializeObject(request);

            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(_apiUrl),
                Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json")
            };

            httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
            httpRequest.Headers.Add("X-Goog-FieldMask", "places/id");



            HttpResponseMessage response = await _httpClient.SendAsync(httpRequest);


            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            var places = JsonConvert.DeserializeObject<DinnerResponseList>(responseBody);

            List<Dinner> dinners = new List<Dinner>();
            if (places != null && places.places != null && places.places.Count != 0)
            {
                foreach (var place in places.places)
                {
                    dinners.Add(new Dinner { googleId = place.id });
                }
            }
            else { throw new ApiException("please use different city"); }

            dinners = dinners.OrderBy(x => Random.Shared.Next()).ToList();
            var diff = dinners.Count - days;

            if (diff <= 0) diff = dinners.Count;
            for (int i = 0; i < diff + 1; i++)
            {
                if (dinners.Count > days)
                    dinners.RemoveAt(dinners.Count - 1);
                else
                    break;
            }

            if (dinners.Count < days)
            {
                for (int i = 0; i < days - dinners.Count; i++)
                {
                    dinners.Add((Dinner)dinners[i]);
                }
            }

            for (int i = 0; i < days; i++)
            {
                dinners[i] = await GetDinnerDetails(dinners[i].googleId, _PRICE_LEVEL);

            }

            return dinners;
        }

        public async Task<Dinner> GetDinnerDetails(string googleId, PRICE_LEVEL pricelevel)
        {
            var detailedUrl = $"https://places.googleapis.com/v1/places/{googleId}";
            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(detailedUrl)
            };

            httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
            httpRequest.Headers.Add("X-Goog-FieldMask", "nationalPhoneNumber,formattedAddress,googleMapsUri,websiteUri,location,rating,regularOpeningHours,priceLevel,displayName,reservable,servesBeer,servesWine,servesBrunch,servesVegetarianFood,shortFormattedAddress,outdoorSeating,liveMusic,menuForChildren,restroom,goodForGroups,paymentOptions,primaryType,photos");

            HttpResponseMessage response = await _httpClient.SendAsync(httpRequest);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            var detailedPlace = JsonConvert.DeserializeObject<DinnerDetailsResponse>(responseBody);

            if (detailedPlace == null) throw new Exception("Failed to retrieve place details");

            var dinner = new Dinner
            {
                googleId = googleId,
                nationalPhoneNumber = detailedPlace.nationalPhoneNumber,
                formattedAddress = detailedPlace.formattedAddress,
                googleMapsUri = detailedPlace.googleMapsUri,
                websiteUri = detailedPlace.websiteUri,
                Location = detailedPlace.location,
                rating = detailedPlace.rating,
                RegularOpeningHours = detailedPlace.regularOpeningHours,
                displayName = detailedPlace.displayName,
                reservable = detailedPlace.reservable,
                servesBrunch = detailedPlace.servesBrunch,
                servesVegetarianFood = detailedPlace.servesVegetarianFood,
                shortFormattedAddress = detailedPlace.shortFormattedAddress,
                outdoorSeating = detailedPlace.outdoorSeating,
                liveMusic = detailedPlace.liveMusic,
                menuForChildren = detailedPlace.menuForChildren,
                restroom = detailedPlace.restroom,
                goodForGroups = detailedPlace.goodForGroups,
                paymentOptions = detailedPlace.paymentOptions,
                primaryType = detailedPlace.primaryType,
                photos = detailedPlace.photos,
                servesWine = detailedPlace.servesWine,
                servesBeer = detailedPlace.servesBeer,
                _PRICE_LEVEL = pricelevel
            };

            return dinner;

        }

        public async Task<TravelOtel> OtelFinder(PRICE_LEVEL _PRICE_LEVEL, string city, int days)
        {
            Random random = new Random();
            var x = 0;
            string queryString = "";
            if (_PRICE_LEVEL == PRICE_LEVEL.PRICE_LEVEL_INEXPENSIVE)
            {
                x = random.Next(1, 3);
                if (x == 1) { queryString = "1 star otels in " + city; }
                else { queryString = "2 stars otels in " + city; }


            }

            else if (_PRICE_LEVEL == PRICE_LEVEL.PRICE_LEVEL_MODERATE)
            {
                x = random.Next(3, 5);
                if (x == 3) { queryString = "3 stars otels in " + city; }
                else { queryString = "4 stars otels in " + city; }

            }

            else if (_PRICE_LEVEL == PRICE_LEVEL.PRICE_LEVEL_EXPENSIVE)
            {
                x = 5;
                queryString = "5 stars otels in " + city;
            }

            else
            {
                throw new Exception("Invalid price level");
            }

            var request = new
            {
                textQuery = queryString
            };

            string jsonRequest = JsonConvert.SerializeObject(request);

            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(_apiUrl),
                Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json")
            };

            httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
            httpRequest.Headers.Add("X-Goog-FieldMask", "places/id");

            HttpResponseMessage response = await _httpClient.SendAsync(httpRequest);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            var places = JsonConvert.DeserializeObject<TravelOtelResponseList>(responseBody);

            List<TravelOtel> otels = new List<TravelOtel>();

            if (places != null && places.places != null && places.places.Count != 0)
            {
                foreach (var place in places.places)
                {
                    otels.Add(new TravelOtel { googleId = place.id });
                }
            }
            else { throw new ApiException("please use different city"); }

            var diff = otels.Count - days;
            if (diff <= 0) diff = otels.Count;
            otels = otels.OrderBy(x => Random.Shared.Next()).ToList();
            for (int i = 0; i < diff + 1; i++)
            {
                if (otels.Count > days)
                    otels.RemoveAt(otels.Count - 1);
                else
                    break;
            }

            if (otels.Count < days)
            {
                for (int i = 0; i < days - otels.Count; i++)
                {
                    otels.Add((TravelOtel)otels[i]);
                }
            }


            otels[0] = await GetOtelDetails(otels[0].googleId, _PRICE_LEVEL, x.ToString());

            return otels[0];

        }

        public async Task<TravelOtel> GetOtelDetails(string googleId, PRICE_LEVEL pricelevel, string otelStar)
        {
            var detailedUrl = $"https://places.googleapis.com/v1/places/{googleId}";
            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(detailedUrl)
            };

            httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
            httpRequest.Headers.Add("X-Goog-FieldMask", "nationalPhoneNumber,internationalPhoneNumber,formattedAddress,googleMapsUri,websiteUri,location,rating,regularOpeningHours,displayName,shortFormattedAddress,goodForChildren,paymentOptions,primaryType,photos");

            HttpResponseMessage response = await _httpClient.SendAsync(httpRequest);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            var detailedPlace = JsonConvert.DeserializeObject<TravelOtelDetailsResponse>(responseBody);

            if (detailedPlace == null) throw new Exception("Failed to retrieve place details");

            var otel = new TravelOtel
            {
                googleId = googleId,
                nationalPhoneNumber = detailedPlace.nationalPhoneNumber,
                internationalPhoneNumber = detailedPlace.internationalPhoneNumber,
                formattedAddress = detailedPlace.formattedAddress,
                googleMapsUri = detailedPlace.googleMapsUri,
                websiteUri = detailedPlace.websiteUri,
                Location = detailedPlace.location,
                rating = detailedPlace.rating,
                regularOpeningHours = detailedPlace.regularOpeningHours,
                displayName = detailedPlace.displayName,
                goodForChildren = detailedPlace.goodForChildren,
                paymentOptions = detailedPlace.paymentOptions,
                primaryType = detailedPlace.primaryType,
                photos = detailedPlace.photos,
                _PRICE_LEVEL = pricelevel,
                star = otelStar,
            };

            return otel;
        }

        public async Task<List<FirstPlaceForRoute>> PlaceFinder(string city, int days, List<string> queries)
        {
            Random random = new Random();
            List<int> listint = new List<int>() { 0, 1, 2, 3, 4, 5 };
            int val1 = random.Next(listint.Count);
            val1 = listint[val1];
            listint.Remove(val1);
            int val2 = random.Next(listint.Count);
            val2 = listint[val2];
            listint.Remove(val2);
            int val3 = random.Next(listint.Count);
            val3 = listint[val3];
            listint.Remove(val3);


            var query = queries[val1] + city;

            var request = new
            {
                textQuery = query
            };

            string jsonRequest = JsonConvert.SerializeObject(request);

            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(_apiUrl),
                Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json")
            };

            httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
            httpRequest.Headers.Add("X-Goog-FieldMask", "places/id");


            HttpResponseMessage response = await _httpClient.SendAsync(httpRequest);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            var places = JsonConvert.DeserializeObject<PlaceResponseList>(responseBody);
            //*****************************************************************************************************************

            query = queries[val2] + city;

            var request1 = new { textQuery = query };

            string jsonRequest1 = JsonConvert.SerializeObject(request1);

            var httpRequest1 = new HttpRequestMessage { Method = HttpMethod.Post, RequestUri = new Uri(_apiUrl), Content = new StringContent(jsonRequest1, Encoding.UTF8, "application/json") };

            httpRequest1.Headers.Add("X-Goog-Api-Key", _apiKey);
            httpRequest1.Headers.Add("X-Goog-FieldMask", "places/id");

            HttpResponseMessage response1 = await _httpClient.SendAsync(httpRequest1);
            response1.EnsureSuccessStatusCode();

            string responseBody1 = await response1.Content.ReadAsStringAsync();
            var places1 = JsonConvert.DeserializeObject<PlaceResponseList>(responseBody1);

            //****************************************************************************************************************

            query = queries[val3] + city;

            var request2 = new { textQuery = query };

            string jsonRequest2 = JsonConvert.SerializeObject(request2);

            var httpRequest2 = new HttpRequestMessage { Method = HttpMethod.Post, RequestUri = new Uri(_apiUrl), Content = new StringContent(jsonRequest1, Encoding.UTF8, "application/json") };

            httpRequest2.Headers.Add("X-Goog-Api-Key", _apiKey);
            httpRequest2.Headers.Add("X-Goog-FieldMask", "places/id");

            HttpResponseMessage response2 = await _httpClient.SendAsync(httpRequest2);
            response2.EnsureSuccessStatusCode();

            string responseBody2 = await response2.Content.ReadAsStringAsync();
            var places2 = JsonConvert.DeserializeObject<PlaceResponseList>(responseBody2);

            if (places.places == null || places1.places == null || places2.places == null) throw new ApiException("please use different city");
            places.places.AddRange(places1.places);
            places.places.AddRange(places2.places);

            HashSet<string> placeIds = new HashSet<string>();
            List<FirstPlaceForRoute> routePlaces = new List<FirstPlaceForRoute>();

            void AddPlaces(List<PlaceResponse> placeList)
            {
                foreach (var place in placeList)
                {
                    if (placeIds.Add(place.id))
                    {
                        var generalPlaceForRoute = new FirstPlaceForRoute
                        {
                            googleId = place.id,
                        };
                        routePlaces.Add(generalPlaceForRoute);
                    }
                }
            }

            AddPlaces(places.places);

            var x = 0;

            if (routePlaces.Count < days * 3)
            {
                while (routePlaces.Count < days * 3) { routePlaces.Add(routePlaces[x]); x++; }
            }

            List<FirstPlaceForRoute> mylist = new List<FirstPlaceForRoute>();

            for (int i = 0; i < routePlaces.Count; i++)
            {
                routePlaces[i] = await GetFirstPlaceDetails(routePlaces[i].googleId);
            }

            return routePlaces;


        }

        public async Task<FirstPlaceForRoute> GetFirstPlaceDetails(string googleId)
        {
            var detailedUrl = $"https://places.googleapis.com/v1/places/{googleId}";
            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(detailedUrl)
            };

            httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
            httpRequest.Headers.Add("X-Goog-FieldMask", "nationalPhoneNumber,formattedAddress,googleMapsUri,websiteUri,location,rating,regularOpeningHours,displayName,goodForChildren,primaryType,photos");

            HttpResponseMessage response = await _httpClient.SendAsync(httpRequest);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            var detailedPlace = JsonConvert.DeserializeObject<PlaceDetailsResponse>(responseBody);

            if (detailedPlace == null) throw new Exception("Failed to retrieve place details");

            var firstplace = new FirstPlaceForRoute
            {
                googleId = googleId,
                nationalPhoneNumber = detailedPlace.nationalPhoneNumber,
                formattedAddress = detailedPlace.formattedAddress,
                googleMapsUri = detailedPlace.googleMapsUri,
                websiteUri = detailedPlace.websiteUri,
                Location = detailedPlace.location,
                rating = detailedPlace.rating,
                regularOpeningHours = detailedPlace.regularOpeningHours,
                displayName = detailedPlace.displayName,
                goodForChildren = detailedPlace.goodForChildren,
                primaryType = detailedPlace.primaryType,
                photos = detailedPlace.photos,
            };

            return firstplace;

        }

        public async Task<List<EventAfterDinner>> NightEventFinder(PRICE_LEVEL _PRICE_LEVEL, string city, int days)
        {
            string queryString = "";
            if (_PRICE_LEVEL == PRICE_LEVEL.PRICE_LEVEL_INEXPENSIVE)
            {
                queryString = "cheap night event in " + city;

            }

            else if (_PRICE_LEVEL == PRICE_LEVEL.PRICE_LEVEL_MODERATE)
            {
                queryString = "moderate night event in " + city;
            }

            else if (_PRICE_LEVEL == PRICE_LEVEL.PRICE_LEVEL_EXPENSIVE)
            {
                queryString = "expensive night event " + city;
            }

            else
            {
                throw new Exception("Invalid price level");
            }


            var request = new
            {
                textQuery = queryString
            };

            string jsonRequest = JsonConvert.SerializeObject(request);

            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(_apiUrl),
                Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json")
            };

            httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
            httpRequest.Headers.Add("X-Goog-FieldMask", "places/id");



            HttpResponseMessage response = await _httpClient.SendAsync(httpRequest);


            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            var places = JsonConvert.DeserializeObject<NightEventResponseList>(responseBody);

            if(places.places == null) throw new ApiException("please use different city");

            HashSet<string> placeIds = new HashSet<string>();
            List<EventAfterDinner> routePlaces = new List<EventAfterDinner>();

            void AddPlaces(List<NightEventResponse> placeList)
            {
                foreach (var place in placeList)
                {
                    if (placeIds.Add(place.id))
                    {
                        var eventAfterDinner = new EventAfterDinner
                        {
                            googleId = place.id,
                        };
                        routePlaces.Add(eventAfterDinner);
                    }
                }
            }

            AddPlaces(places.places);

            var x = 0;

            if (routePlaces.Count < days * 3)
            {
                while (routePlaces.Count < days * 3) { routePlaces.Add(routePlaces[x]); x++; }
            }           

            for (int i = 0; i < routePlaces.Count; i++)
            {
                routePlaces[i] = await GetNightEventDetails(routePlaces[i].googleId);
            }

            return routePlaces;

        }

        public async Task<EventAfterDinner> GetNightEventDetails(string googleId)
        {
            var detailedUrl = $"https://places.googleapis.com/v1/places/{googleId}";
            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(detailedUrl)
            };

            httpRequest.Headers.Add("X-Goog-Api-Key", _apiKey);
            httpRequest.Headers.Add("X-Goog-FieldMask", "nationalPhoneNumber,formattedAddress,googleMapsUri,websiteUri,location,rating,regularOpeningHours,displayName,goodForChildren,primaryType,photos,takeout,delivery,curbsidePickup,servesCocktails,servesWine,servesBeer,reservable,outdoorSeating,liveMusic,restroom,goodForGroups,paymentOptions");

            HttpResponseMessage response = await _httpClient.SendAsync(httpRequest);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            var detailedPlace = JsonConvert.DeserializeObject<NightEventDetailsResponse>(responseBody);

            if (detailedPlace == null) throw new Exception("Failed to retrieve place details");

            var nightplace = new EventAfterDinner
            {
                googleId = googleId,
                nationalPhoneNumber = detailedPlace.nationalPhoneNumber,
                formattedAddress = detailedPlace.formattedAddress,
                googleMapsUri = detailedPlace.googleMapsUri,
                websiteUri = detailedPlace.websiteUri,
                Location = detailedPlace.location,
                rating = detailedPlace.rating,
                RegularOpeningHours = detailedPlace.regularOpeningHours,
                displayName = detailedPlace.displayName,
                goodForChildren = detailedPlace.goodForChildren,
                primaryType = detailedPlace.primaryType,
                photos = detailedPlace.photos,
                takeout = detailedPlace.takeout,
                delivery = detailedPlace.delivery,
                curbsidePickup = detailedPlace.curbsidePickup,
                servesCocktails = detailedPlace.servesCocktails,
                servesWine = detailedPlace.servesWine,
                servesBeer = detailedPlace.servesBeer,
                reservable = detailedPlace.reservable,
                outdoorSeating = detailedPlace.outdoorSeating,
                liveMusic = detailedPlace.liveMusic,
                restroom = detailedPlace.restroom,
                goodForGroups = detailedPlace.goodForGroups,
                paymentOptions = detailedPlace.paymentOptions

            };

            return nightplace;
        }

        public async Task<GetRouteComponentQueryResponse> GetRouteComponentImage(GetRouteComponentQueryRequest getRouteComponentQueryRequest)
        {
            string url = $"{_imageApiUrl}{getRouteComponentQueryRequest.placeAndPhotoID}/media?maxWidthPx={getRouteComponentQueryRequest.maxWidthPx}&maxHeightPx={getRouteComponentQueryRequest.maxHeightPx}";
            _httpClient.DefaultRequestHeaders.Add("X-Goog-Api-Key", _apiKey);
            byte[] photoBytes = await _httpClient.GetByteArrayAsync(url);
            Console.WriteLine(photoBytes);

            using MemoryStream ms = new MemoryStream(photoBytes);
            using SixLabors.ImageSharp.Image image = await SixLabors.ImageSharp.Image.LoadAsync(ms);

            GetRouteComponentQueryResponse getRouteComponentQueryResponse = new GetRouteComponentQueryResponse();
            getRouteComponentQueryResponse.PhotoBytes = photoBytes;
            return getRouteComponentQueryResponse;
        }

    }
}
