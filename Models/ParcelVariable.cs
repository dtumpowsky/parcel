namespace Parcels.Models
{
    public class ParcelVariable
    {
        private int _height;
        public int GetHeight()
        {
          return _height;
        }
        public void SetHeight(int newHeight)
        {
          _height = newHeight;
        }

        private int _width;
        public int GetWidth()
        {
          return _width;
        }
        public void SetWidth(int newWidth)
        {
          _width = newWidth;
        }
        private int _length;
        public int GetLength()
        {
          return _length;
        }
        public void SetLength(int newLength)
        {
          _length = newLength;
        }

        private int _weight;
        public int GetWeight()
        {
          return _weight;
        }
        public void SetWeight(int newWeight)
        {
          _weight = newWeight;
        }

        private int _distance;
        public int GetDistance()
        {
          return _distance;
        }
        public void SetDistance(int newDistance)
        {
          _distance = newDistance;
        }

        public int GetVolume()
        {
          return (_weight * _height * _length);
        }

        public int GetCost()
        {
          return (_distance * _weight);
        }

        private int _result;
        public int GetResult()
        {
          return _result;
        }
        public void SetResult(int newResult)
        {
          _result = newResult;
        }

        private int _result2;
        public int GetResult2()
        {
          return _result2;
        }
        public void SetResult2(int newResult2)
        {
          _result2 = newResult2;
        }
    }
}
