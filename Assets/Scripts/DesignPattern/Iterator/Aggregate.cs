using System.Collections;
using System.Collections.Generic;
using DesignPattern.Iterator.Interface;

namespace DesignPattern.Iterator
{
    public class Aggregate : IEnumerable<SpecialData>
    {
        private List<SpecialData> _specialDatas;

        public Aggregate()
        {
            _specialDatas = new List<SpecialData>();
        }
        public void AddData(SpecialData data)
        {
            _specialDatas.Add(data);
        }

        public void RemoveData(SpecialData data)
        {
            _specialDatas.Remove(data);
        }

        public List<SpecialData> GetSpecialDatas()
        {
            return _specialDatas;
        }

        IEnumerator<SpecialData> IEnumerable<SpecialData>.GetEnumerator()
        {
            return new Iterator(this);
        }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }
    }
}