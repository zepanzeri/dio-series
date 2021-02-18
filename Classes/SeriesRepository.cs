using System;
using System.Collections.Generic;
using dio_series.Interfaces;

namespace dio_series
{
    public class SeriesRepository:Repository<Series>
    {
        private List<Series> listSeries = new List<Series>();

        public List<Series> List(){
            return listSeries;
        }
        public Series ReturnById(int id){
            return listSeries[id];
        }
        public void Insert(Series serie){
            listSeries.Add(serie);
        }
        public void Delete(int id){
            listSeries[id].Delete();
        }
        public void Update(int id, Series serie){
            listSeries[id] = serie;
        }
        public int NextId(){
            return listSeries.Count;
        }
    }
}