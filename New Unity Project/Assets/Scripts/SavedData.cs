using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public sealed class SavedData<T> : BaseExample<int>
    {
        public SavedData(int id) : base(id)
        {

        }
    }

    public class BaseExample<T>
    {
        public T IdPlayer = default;

        public BaseExample(T id)
        {
            IdPlayer = id;
        }
    }

    public class TEST2
    {
        public void Test()
        {
            BaseExample<int> ggg = new BaseExample<int>(2);
            BaseExample<int> hhh = new SavedData<string>(2);
            SavedData<string> jjj = new SavedData<string>(2);
        }
    }
}
