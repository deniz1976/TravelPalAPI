using CleanArchitecture.Core.Entities.TravelEntities;
using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Features.TravelRoute.Commands.CreateRoute;
using CleanArchitecture.Core.Features.TravelRoute.Queries.RouteComponentImage;
using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Core.Interfaces.Route;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Car , PublicTransport , OnFoot

namespace CleanArchitecture.Infrastructure.Services
{
    public class TravelService : ITravelService
    {
        private readonly IRouteReadRepository _routeReadRepository;
        private readonly IRouteWriteRepository _routeWriteRepository;
        public TravelService(IRouteWriteRepository routeWriteRepository , IRouteReadRepository routeReadRepository) 
        {
            _routeWriteRepository = routeWriteRepository;
            _routeReadRepository = routeReadRepository;

        }

        public async Task<CreateRouteCommandResponse> CreateRoute(CreateRouteCommandRequest request, int days)
        {
            Random random = new Random();

            if (days <= 0 || days > 7) throw new ApiException("days cant be <0 or >7");
            List<TravelRoute> _TravelRoutes = new List<TravelRoute>();
            List<string> queryList = new List<string>
            {
                "Top attractions in ",
                "Best sightseeing spots in ",
                "Historical sites in ",
                "Cultural attractions in ",
                "Nature spots in ",
                "Tourist destinations in "
            };
            var placeInt1 = random.Next(queryList.Count);
            var placeQuery1 = queryList[placeInt1];


    //        if (request.TransportVehicle == "OnFoot") // distance matters so use nearby places
    //        {
    //            throw new NotImplementedException();
    //        }

    //        TravelRoute travelRoute = new TravelRoute();
    //        TravelOtel otel = new TravelOtel();
    //        Breakfast breakfast = new Breakfast();
    //        Lunch lunch = new Lunch();
    //        Dinner dinner = new Dinner();
    //        FirstPlaceForRoute firstPlaceForRoute = new FirstPlaceForRoute();
    //        SecondPlaceForRoute secondPlaceForRoute = new SecondPlaceForRoute();
    //        ThirdPlaceForRoute thirdPlaceForRoute = new ThirdPlaceForRoute();
    //        EventAfterDinner eventAfterDinner = new EventAfterDinner();

    //        lunch = new Lunch()
    //        {
    //            servesBeer = true,
    //            servesWine = false,
    //            nationalPhoneNumber = "+1234567890",
    //            formattedAddress = "123 Main St, Anytown, USA",
    //            rating = 4.5,
    //            googleMapsUri = "http://maps.google.com/...",
    //            websiteUri = "http://example.com",
    //            Location = new Location()
    //            {
    //                latitude = 40.7128,
    //                longitude = -74.0060
    //            },
    //            RegularOpeningHours = new RegularOpeningHours()
    //            {
    //                openNow = true,
    //                periods = new List<Period>()
    //    {
    //            new Period()
    //        {
    //            open = new Open() { day = 1, hour = 9, minute = 0 },
    //            close = new Close() { day = 1, hour = 17, minute = 0 }
    //        }
    //    },
    //                weekdayDescriptions = new List<string>()
    //    {
    //        "Monday: 9:00 AM – 5:00 PM"
    //    }
    //            },
    //            _PRICE_LEVEL = PRICE_LEVEL.PRICE_LEVEL_MODERATE,
    //            displayName = new DisplayName()
    //            {
    //                text = "Example Restaurant",
    //                langugageCode = "en"
    //            },
    //            reservable = true,
    //            servesBrunch = false,
    //            servesVegetarianFood = true,
    //            shortFormattedAddress = "123 Main St",
    //            outdoorSeating = true,
    //            liveMusic = false,
    //            menuForChildren = true,
    //            restroom = true,
    //            goodForGroups = true,
    //            paymentOptions = new PaymentOptions()
    //            {
    //                acceptsCreditCards = "true",
    //                acceptsDebitCards = "true",
    //                acceptsCashOnly = "false"
    //            },
    //            photos = new List<Photos>()
    //{
    //            new Photos()
    //    {
    //        name = "photo1.jpg",
    //        widthPx = 800,
    //        heightPx = 600
    //    }
    //},
    //            primaryType = "Restaurant",
    //            googleId = "abcd1234"
    //        };

    //        breakfast = new Breakfast()
    //        {
    //            nationalPhoneNumber = "+1234567890",
    //            formattedAddress = "123 Main St, Anytown, USA",
    //            rating = 4.5,
    //            googleMapsUri = "http://maps.google.com/...",
    //            websiteUri = "http://example.com",
    //            Location = new Location()
    //            {
    //                latitude = 40.7128,
    //                longitude = -74.0060
    //            },
    //            RegularOpeningHours = new RegularOpeningHours()
    //            {
    //                openNow = true,
    //                periods = new List<Period>()
    //    {
    //            new Period()
    //        {
    //            open = new Open() { day = 1, hour = 9, minute = 0 },
    //            close = new Close() { day = 1, hour = 17, minute = 0 }
    //        }
    //    },
    //                weekdayDescriptions = new List<string>()
    //    {
    //        "Monday: 9:00 AM – 5:00 PM"
    //    }
    //            },
    //            _PRICE_LEVEL = PRICE_LEVEL.PRICE_LEVEL_MODERATE,
    //            displayName = new DisplayName()
    //            {
    //                text = "Example Restaurant",
    //                langugageCode = "en"
    //            },
    //            reservable = true,
    //            servesBrunch = false,
    //            servesVegetarianFood = true,
    //            shortFormattedAddress = "123 Main St",
    //            outdoorSeating = true,
    //            liveMusic = false,
    //            menuForChildren = true,
    //            restroom = true,
    //            goodForGroups = true,
    //            paymentOptions = new PaymentOptions()
    //            {
    //                acceptsCreditCards = "true",
    //                acceptsDebitCards = "true",
    //                acceptsCashOnly = "false"
    //            },
    //            photos = new List<Photos>()
    //{
    //            new Photos()
    //    {
    //        name = "photo1.jpg",
    //        widthPx = 800,
    //        heightPx = 600
    //    }
    //},
    //            primaryType = "Restaurant",
    //            googleId = "abcd1234"
    //        };

    //        dinner = new Dinner()
    //        {
    //            servesBeer = true,
    //            servesWine = false,
    //            nationalPhoneNumber = "+1234567890",
    //            formattedAddress = "123 Main St, Anytown, USA",
    //            rating = 4.5,
    //            googleMapsUri = "http://maps.google.com/...",
    //            websiteUri = "http://example.com",
    //            Location = new Location()
    //            {
    //                latitude = 40.7128,
    //                longitude = -74.0060
    //            },
    //            RegularOpeningHours = new RegularOpeningHours()
    //            {
    //                openNow = true,
    //                periods = new List<Period>()
    //    {
    //            new Period()
    //        {
    //            open = new Open() { day = 1, hour = 9, minute = 0 },
    //            close = new Close() { day = 1, hour = 17, minute = 0 }
    //        }
    //    },
    //                weekdayDescriptions = new List<string>()
    //    {
    //        "Monday: 9:00 AM – 5:00 PM"
    //    }
    //            },
    //            _PRICE_LEVEL = PRICE_LEVEL.PRICE_LEVEL_MODERATE,
    //            displayName = new DisplayName()
    //            {
    //                text = "Example Restaurant",
    //                langugageCode = "en"
    //            },
    //            reservable = true,
    //            servesBrunch = false,
    //            servesVegetarianFood = true,
    //            shortFormattedAddress = "123 Main St",
    //            outdoorSeating = true,
    //            liveMusic = false,
    //            menuForChildren = true,
    //            restroom = true,
    //            goodForGroups = true,
    //            paymentOptions = new PaymentOptions()
    //            {
    //                acceptsCreditCards = "true",
    //                acceptsDebitCards = "true",
    //                acceptsCashOnly = "false"
    //            },
    //            photos = new List<Photos>()
    //{
    //            new Photos()
    //    {
    //        name = "photo1.jpg",
    //        widthPx = 800,
    //        heightPx = 600
    //    }
    //        },
    //            primaryType = "Restaurant",
    //            googleId = "abcd1234"

    //        };

    //        firstPlaceForRoute = new FirstPlaceForRoute()
    //        {
    //            nationalPhoneNumber = "+1234567890",
    //            formattedAddress = "123 Main St, Anytown, USA",
    //            rating = 4.5,
    //            googleMapsUri = "http://maps.google.com/...",
    //            websiteUri = "http://example.com",
    //            Location = new Location()
    //            {
    //                latitude = 40.7128,
    //                longitude = -74.0060
    //            },
    //            regularOpeningHours = new RegularOpeningHours()
    //            {
    //                openNow = true,
    //                periods = new List<Period>()
    //    {
    //            new Period()
    //        {
    //            open = new Open() { day = 1, hour = 9, minute = 0 },
    //            close = new Close() { day = 1, hour = 17, minute = 0 }
    //        }
    //    },
    //                weekdayDescriptions = new List<string>()
    //    {
    //        "Monday: 9:00 AM – 5:00 PM"
    //    }
    //            },
    //            _PRICE_LEVEL = PRICE_LEVEL.PRICE_LEVEL_MODERATE,
    //            displayName = new DisplayName()
    //            {
    //                text = "Example Restaurant",
    //                langugageCode = "en"
    //            },
    //            photos = new List<Photos>()
    //                {
    //            new Photos()
    //         {
    //        name = "photo1.jpg",
    //        widthPx = 800,
    //        heightPx = 600
    //    }
    //        },
    //            primaryType = "Restaurant",
    //            googleId = "abcd1234"
    //        };

    //        secondPlaceForRoute = new SecondPlaceForRoute()
    //        {
    //            nationalPhoneNumber = "+1234567890",
    //            formattedAddress = "123 Main St, Anytown, USA",
    //            rating = 4.5,
    //            googleMapsUri = "http://maps.google.com/...",
    //            websiteUri = "http://example.com",
    //            Location = new Location()
    //            {
    //                latitude = 40.7128,
    //                longitude = -74.0060
    //            },
    //            regularOpeningHours = new RegularOpeningHours()
    //            {
    //                openNow = true,
    //                periods = new List<Period>()
    //    {
    //            new Period()
    //        {
    //            open = new Open() { day = 1, hour = 9, minute = 0 },
    //            close = new Close() { day = 1, hour = 17, minute = 0 }
    //        }
    //    },
    //                weekdayDescriptions = new List<string>()
    //    {
    //        "Monday: 9:00 AM – 5:00 PM"
    //    }
    //            },
    //            _PRICE_LEVEL = PRICE_LEVEL.PRICE_LEVEL_MODERATE,
    //            displayName = new DisplayName()
    //            {
    //                text = "Example Restaurant",
    //                langugageCode = "en"
    //            },
    //            photos = new List<Photos>()
    //                {
    //            new Photos()
    //         {
    //        name = "photo1.jpg",
    //        widthPx = 800,
    //        heightPx = 600
    //    }
    //        },
    //            primaryType = "Restaurant",
    //            googleId = "abcd1234"

    //        };

    //        thirdPlaceForRoute = new ThirdPlaceForRoute()
    //        {
    //            nationalPhoneNumber = "+1234567890",
    //            formattedAddress = "123 Main St, Anytown, USA",
    //            rating = 4.5,
    //            googleMapsUri = "http://maps.google.com/...",
    //            websiteUri = "http://example.com",
    //            Location = new Location()
    //            {
    //                latitude = 40.7128,
    //                longitude = -74.0060
    //            },
    //            regularOpeningHours = new RegularOpeningHours()
    //            {
    //                openNow = true,
    //                periods = new List<Period>()
    //    {
    //            new Period()
    //        {
    //            open = new Open() { day = 1, hour = 9, minute = 0 },
    //            close = new Close() { day = 1, hour = 17, minute = 0 }
    //        }
    //    },
    //                weekdayDescriptions = new List<string>()
    //    {
    //        "Monday: 9:00 AM – 5:00 PM"
    //    }
    //            },
    //            _PRICE_LEVEL = PRICE_LEVEL.PRICE_LEVEL_MODERATE,
    //            displayName = new DisplayName()
    //            {
    //                text = "Example Restaurant",
    //                langugageCode = "en"
    //            },
    //            photos = new List<Photos>()
    //                {
    //            new Photos()
    //         {
    //        name = "photo1.jpg",
    //        widthPx = 800,
    //        heightPx = 600
    //    }
    //        },
    //            primaryType = "Restaurant",
    //            googleId = "abcd1234"
    //        };

    //        eventAfterDinner = new EventAfterDinner()
    //        {
    //            nationalPhoneNumber = "+1234567890",
    //            formattedAddress = "123 Main St, Anytown, USA",
    //            rating = 4.5,
    //            googleMapsUri = "http://maps.google.com/...",
    //            websiteUri = "http://example.com",
    //            Location = new Location()
    //            {
    //                latitude = 40.7128,
    //                longitude = -74.0060
    //            },
    //            RegularOpeningHours = new RegularOpeningHours()
    //            {
    //                openNow = true,
    //                periods = new List<Period>()
    //                {
    //                    new Period()
    //                    {
    //                        open = new Open() { day = 1, hour = 9, minute = 0 },
    //                        close = new Close() { day = 1, hour = 17, minute = 0 }
    //                    }
    //                },
    //                weekdayDescriptions = new List<string>()
    //                {
    //                    "Monday: 9:00 AM – 5:00 PM"
    //                }
    //            },
    //            _PRICE_LEVEL = PRICE_LEVEL.PRICE_LEVEL_MODERATE,
    //            displayName = new DisplayName()
    //            {
    //                text = "Example Restaurant",
    //                langugageCode = "en"
    //            },
    //            photos = new List<Photos>()
    //            {
    //                new Photos()
    //                {
    //                    name = "photo1.jpg",
    //                    widthPx = 800,
    //                    heightPx = 600
    //                }
    //            },
    //            primaryType = "Restaurant",
    //            googleId = "abcd1234",
    //            takeout = true,
    //            delivery = true,
    //            curbsidePickup = true,
    //            servesBeer = true,
    //            servesWine = true,
    //            servesCocktails = true,
    //            goodForChildren = false,
    //            paymentOptions = new PaymentOptions()
    //            {
    //                acceptsCreditCards = "true",
    //                acceptsDebitCards = "true",
    //                acceptsCashOnly = "false"
    //            },

    //        };

    //        otel = new TravelOtel()
    //        {
    //            star = "5",
    //            internationalPhoneNumber = "5352364325",
    //            nationalPhoneNumber = "5352364325",
    //            formattedAddress = "789 Lunch St, Antalya, Turkey",
    //            Location = new Location()
    //            {
    //                latitude = 40.7128,
    //                longitude = -74.0060
    //            },
    //            regularOpeningHours = new RegularOpeningHours()
    //            {
    //                openNow = true,
    //                periods = new List<Period>()
    //                {
    //                    new Period()
    //                    {
    //                        open = new Open() { day = 1, hour = 9, minute = 0 },
    //                        close = new Close() { day = 1, hour = 17, minute = 0 }
    //                    }
    //                },
    //                weekdayDescriptions = new List<string>()
    //                {
    //                    "Monday: 9:00 AM – 5:00 PM"
    //                }
    //            },
    //            _PRICE_LEVEL = PRICE_LEVEL.PRICE_LEVEL_MODERATE,
    //            displayName = new DisplayName()
    //            {
    //                text = "Example Restaurant",
    //                langugageCode = "en"
    //            },
    //            photos = new List<Photos>()
    //            {
    //                new Photos()
    //                {
    //                    name = "photo1.jpg",
    //                    widthPx = 800,
    //                    heightPx = 600
    //                }
    //            },
    //            primaryType = "Otel",
    //            googleId = "abcd1234",
    //            paymentOptions = new PaymentOptions()
    //            {
    //                acceptsCreditCards = "true",
    //                acceptsDebitCards = "true",
    //                acceptsCashOnly = "false"
    //            },
    //            rating = 5,
    //            googleMapsUri = "www.google.com",
    //            websiteUri = "www.google.com"
    //        };

    //        travelRoute.Otel = otel;
    //        travelRoute.Breakfast = breakfast;
    //        travelRoute.Dinner = dinner;
    //        travelRoute.Lunch = lunch;
    //        travelRoute.FirstPlaceForRoute = firstPlaceForRoute;
    //        travelRoute.SecondPlaceForRoute = secondPlaceForRoute;
    //        travelRoute.ThirdPlaceForRoute = thirdPlaceForRoute;
    //        travelRoute.EventAfterDinner = eventAfterDinner;
    //        travelRoute.isLiked = false;
    //        travelRoute.userId = "8ccafd58-6114-4122-a59a-8aae932b5551";
    //        travelRoute.routeName = null;
    //        travelRoute.Days = 3;
    //        travelRoute._PRICE_LEVEL = PRICE_LEVEL.PRICE_LEVEL_EXPENSIVE;
    //        travelRoute.TransportVehicle = "Car";


    //        List<TravelRoute> routess = new List<TravelRoute>
    //        {
    //            travelRoute,
    //            travelRoute,
    //            travelRoute
    //        };

    //        await _routeWriteRepository.AddAsync(travelRoute);
    //        await _routeWriteRepository.SaveAsync();

    //        return new CreateRouteCommandResponse()
    //        {
    //            TravelRoutes = routess
    //        };




            if (request.TransportVehicle != "OnFoot" && request.TransportVehicle != "Car" && request.TransportVehicle != "PublicTransport")
            {
                throw new ApiException("Transport vehicle must be OnFoot, Car or PublicTransport");
            }


            else
            {
                HttpClient httpClient = new HttpClient();
                PlacesService placesService = new PlacesService(httpClient,_routeWriteRepository,_routeReadRepository);
                TravelOtel travelOtel = await placesService.OtelFinder(PRICE_LEVEL.PRICE_LEVEL_EXPENSIVE, request.CountryOrCity, days);
                if (travelOtel == null) return null;
                List<Breakfast> breakfasts = await placesService.BreakfastFinder(PRICE_LEVEL.PRICE_LEVEL_EXPENSIVE, request.CountryOrCity, days);
                if (breakfasts.Count == 0) return null;
                List<Lunch> lunches = await placesService.LunchFinder(PRICE_LEVEL.PRICE_LEVEL_EXPENSIVE, request.CountryOrCity, days);
                List<Dinner> dinners = await placesService.DinnerFinder(PRICE_LEVEL.PRICE_LEVEL_EXPENSIVE, request.CountryOrCity, days);
                List<FirstPlaceForRoute> firstPlaces = await placesService.PlaceFinder(request.CountryOrCity, days, queryList);
                List<EventAfterDinner> events = await placesService.NightEventFinder(PRICE_LEVEL.PRICE_LEVEL_EXPENSIVE, request.CountryOrCity, days);
                TravelOtel inexpensiveTravelOtel = await placesService.OtelFinder(PRICE_LEVEL.PRICE_LEVEL_INEXPENSIVE, request.CountryOrCity, days);
                List<Breakfast> inexpensiveBreakfasts = await placesService.BreakfastFinder(PRICE_LEVEL.PRICE_LEVEL_INEXPENSIVE, request.CountryOrCity, days);
                List<Lunch> inexpensiveLunches = await placesService.LunchFinder(PRICE_LEVEL.PRICE_LEVEL_INEXPENSIVE, request.CountryOrCity, days);
                List<Dinner> inexpensiveDinners = await placesService.DinnerFinder(PRICE_LEVEL.PRICE_LEVEL_INEXPENSIVE, request.CountryOrCity, days);
                List<EventAfterDinner> inexpensiveNightEvents = await placesService.NightEventFinder(PRICE_LEVEL.PRICE_LEVEL_INEXPENSIVE, request.CountryOrCity, days);
                TravelOtel moderateTravelOtel = await placesService.OtelFinder(PRICE_LEVEL.PRICE_LEVEL_MODERATE, request.CountryOrCity, days);
                List<Breakfast> moderateBreakfasts = await placesService.BreakfastFinder(PRICE_LEVEL.PRICE_LEVEL_MODERATE, request.CountryOrCity, days);
                List<Lunch> moderateLunches = await placesService.LunchFinder(PRICE_LEVEL.PRICE_LEVEL_MODERATE, request.CountryOrCity, days);
                List<Dinner> moderateDinners = await placesService.DinnerFinder(PRICE_LEVEL.PRICE_LEVEL_MODERATE, request.CountryOrCity, days);
                List<EventAfterDinner> moderateNightEvents = await placesService.NightEventFinder(PRICE_LEVEL.PRICE_LEVEL_MODERATE, request.CountryOrCity, days);


                for (int i = 0; i < lunches.Capacity + breakfasts.Capacity + dinners.Capacity;i++) 
                {
                    for (int j = 0; j < lunches.Capacity + breakfasts.Capacity + dinners.Capacity; j++)
                    {
                        
                    }
                }

                for (int i = 0; i < days; i++)
                {
                    var x = random.Next(firstPlaces.Count);
                    SecondPlaceForRoute s = new SecondPlaceForRoute()
                    {
                        nationalPhoneNumber = firstPlaces[x].nationalPhoneNumber,
                        formattedAddress = firstPlaces[x].formattedAddress,
                        Location = firstPlaces[x].Location,
                        rating = firstPlaces[x].rating,
                        googleMapsUri = firstPlaces[x].googleMapsUri,
                        regularOpeningHours = firstPlaces[x].regularOpeningHours,
                        displayName = firstPlaces[x].displayName,
                        goodForChildren = firstPlaces[x].goodForChildren,
                        photos = firstPlaces[x].photos,
                        primaryType = firstPlaces[x].primaryType,
                        googleId = firstPlaces[x].googleId,

                    };

                    firstPlaces.RemoveAt(x);
                    x = random.Next(firstPlaces.Count);

                    ThirdPlaceForRoute t = new ThirdPlaceForRoute()
                    {
                        nationalPhoneNumber = firstPlaces[x].nationalPhoneNumber,
                        formattedAddress = firstPlaces[x].formattedAddress,
                        Location = firstPlaces[x].Location,
                        rating = firstPlaces[x].rating,
                        googleMapsUri = firstPlaces[x].googleMapsUri,
                        regularOpeningHours = firstPlaces[x].regularOpeningHours,
                        displayName = firstPlaces[x].displayName,
                        goodForChildren = firstPlaces[x].goodForChildren,
                        photos = firstPlaces[x].photos,
                        primaryType = firstPlaces[x].primaryType,
                        googleId = firstPlaces[x].googleId,

                    };


                    _TravelRoutes.Add(new TravelRoute
                    {
                        userId = request.userId.ToString(),
                        Days = days,
                        TransportVehicle = request.TransportVehicle,
                        _PRICE_LEVEL = PRICE_LEVEL.PRICE_LEVEL_EXPENSIVE,
                        Otel = travelOtel,
                        Lunch = lunches[i],
                        Dinner = dinners[i],
                        FirstPlaceForRoute = firstPlaces[i],
                        SecondPlaceForRoute = s,
                        ThirdPlaceForRoute = t,
                        EventAfterDinner = events[i],
                        Breakfast = breakfasts[i]
                    });

                }

                for (int i = 0; i < days; i++)
                {

                    var x = random.Next(firstPlaces.Count);
                    SecondPlaceForRoute s = new SecondPlaceForRoute()
                    {
                        nationalPhoneNumber = firstPlaces[x].nationalPhoneNumber,
                        formattedAddress = firstPlaces[x].formattedAddress,
                        Location = firstPlaces[x].Location,
                        rating = firstPlaces[x].rating,
                        googleMapsUri = firstPlaces[x].googleMapsUri,
                        regularOpeningHours = firstPlaces[x].regularOpeningHours,
                        displayName = firstPlaces[x].displayName,
                        goodForChildren = firstPlaces[x].goodForChildren,
                        photos = firstPlaces[x].photos,
                        primaryType = firstPlaces[x].primaryType,
                        googleId = firstPlaces[x].googleId,

                    };

                    firstPlaces.RemoveAt(x);
                    x = random.Next(firstPlaces.Count);

                    ThirdPlaceForRoute t = new ThirdPlaceForRoute()
                    {
                        nationalPhoneNumber = firstPlaces[x].nationalPhoneNumber,
                        formattedAddress = firstPlaces[x].formattedAddress,
                        Location = firstPlaces[x].Location,
                        rating = firstPlaces[x].rating,
                        googleMapsUri = firstPlaces[x].googleMapsUri,
                        regularOpeningHours = firstPlaces[x].regularOpeningHours,
                        displayName = firstPlaces[x].displayName,
                        goodForChildren = firstPlaces[x].goodForChildren,
                        photos = firstPlaces[x].photos,
                        primaryType = firstPlaces[x].primaryType,
                        googleId = firstPlaces[x].googleId,

                    };

                    _TravelRoutes.Add(new TravelRoute
                    {
                        userId = request.userId.ToString(),
                        Days = days,
                        TransportVehicle = request.TransportVehicle,
                        _PRICE_LEVEL = PRICE_LEVEL.PRICE_LEVEL_MODERATE,
                        Otel = moderateTravelOtel,
                        Lunch = moderateLunches[i],
                        Dinner = moderateDinners[i],
                        FirstPlaceForRoute = firstPlaces[i],
                        SecondPlaceForRoute = s,
                        ThirdPlaceForRoute = t,
                        EventAfterDinner = moderateNightEvents[i],
                        Breakfast = moderateBreakfasts[i]
                    });
                }

                for (int i = 0; i < days; i++)
                {
                    var x = random.Next(firstPlaces.Count);
                    SecondPlaceForRoute s = new SecondPlaceForRoute()
                    {
                        nationalPhoneNumber = firstPlaces[x].nationalPhoneNumber,
                        formattedAddress = firstPlaces[x].formattedAddress,
                        Location = firstPlaces[x].Location,
                        rating = firstPlaces[x].rating,
                        googleMapsUri = firstPlaces[x].googleMapsUri,
                        regularOpeningHours = firstPlaces[x].regularOpeningHours,
                        displayName = firstPlaces[x].displayName,
                        goodForChildren = firstPlaces[x].goodForChildren,
                        photos = firstPlaces[x].photos,
                        primaryType = firstPlaces[x].primaryType,
                        googleId = firstPlaces[x].googleId,

                    };

                    firstPlaces.RemoveAt(x);
                    x = random.Next(firstPlaces.Count);

                    ThirdPlaceForRoute t = new ThirdPlaceForRoute()
                    {
                        nationalPhoneNumber = firstPlaces[x].nationalPhoneNumber,
                        formattedAddress = firstPlaces[x].formattedAddress,
                        Location = firstPlaces[x].Location,
                        rating = firstPlaces[x].rating,
                        googleMapsUri = firstPlaces[x].googleMapsUri,
                        regularOpeningHours = firstPlaces[x].regularOpeningHours,
                        displayName = firstPlaces[x].displayName,
                        goodForChildren = firstPlaces[x].goodForChildren,
                        photos = firstPlaces[x].photos,
                        primaryType = firstPlaces[x].primaryType,
                        googleId = firstPlaces[x].googleId,

                    };


                    _TravelRoutes.Add(new TravelRoute
                    {
                        userId = request.userId.ToString(),
                        Days = days,
                        TransportVehicle = request.TransportVehicle,
                        _PRICE_LEVEL = PRICE_LEVEL.PRICE_LEVEL_INEXPENSIVE,
                        Otel = inexpensiveTravelOtel,
                        Lunch = inexpensiveLunches[i],
                        Dinner = inexpensiveDinners[i],
                        FirstPlaceForRoute = firstPlaces[i],
                        SecondPlaceForRoute = s,
                        ThirdPlaceForRoute = t,
                        EventAfterDinner = inexpensiveNightEvents[i],
                        Breakfast = inexpensiveBreakfasts[i]
                    });
                }


            }

            for (int i = 0; i < _TravelRoutes.Count; i++) 
            {
                _TravelRoutes[i].isLiked = false;
                _TravelRoutes[i]._PRICE_LEVEL = _TravelRoutes[i].Breakfast._PRICE_LEVEL;
                _TravelRoutes[i].routeName = "";
                _TravelRoutes[i].TransportVehicle = request.TransportVehicle;
                await _routeWriteRepository.AddAsync(_TravelRoutes[i]);
            }
            await _routeWriteRepository.SaveAsync();

            return new CreateRouteCommandResponse { TravelRoutes = _TravelRoutes };
        }


    }
}
