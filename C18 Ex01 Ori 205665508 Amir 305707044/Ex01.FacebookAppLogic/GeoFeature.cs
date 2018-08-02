using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GMap.NET;
using FacebookWrapper.ObjectModel;

namespace Ex01.FacebookAppLogic
{

    public class GeoFeature
    {

        private FacebookObjectCollection<Checkin> m_UserCheckins = null;
        private FacebookObjectCollection<Photo> m_UserPhotos = null;

        public void Spy(FacebookAppEngine i_App)
        {
            m_UserCheckins = i_App.FetchUserCheckins();
            m_UserPhotos = i_App.FetchUserPhotos();

            createArrayOfLocations();
        }

        private void createArrayOfLocations()
        {
            foreach (Checkin checkin in m_UserCheckins)
            {
                PointLatLng currentItemLocation = new PointLatLng((double)checkin.Place.Location.Latitude, (double)checkin.Place.Location.Longitude);
               
                m_AllLocations.Add(currentItemLocation);
            }
            foreach (Photo photo in m_UserPhotos)
            {
                PointLatLng currentItemLocation = new PointLatLng((double)photo.Place.Location.Latitude, (double)photo.Place.Location.Longitude);
                m_AllLocations.Add(currentItemLocation);
            }
        }


        public List<PointLatLng> Locations
        {
            get { return m_AllLocations; }
        }

        private List<PointLatLng> m_AllLocations = new List<PointLatLng>();


    }

}
