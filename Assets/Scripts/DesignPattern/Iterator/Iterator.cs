using System.Collections;
using System.Collections.Generic;
using DesignPattern.Iterator.Interface;

namespace DesignPattern.Iterator
{
    /*
    对于泛型类型参数，out 关键字可指定类型参数是协变的。 可以在泛型接口和委托中使用 out 关键字。
    协变使你使用的类型可以比泛型参数指定的类型派生程度更大。 这样可以隐式转换实现协变接口的类以及隐式转换委托类型。 引用类型支持协变和逆变，但值类型不支持它们。

    具有协变类型参数的接口使其方法返回的类型可以比类型参数指定的类型派生程度更大。 
    例如，因为在 .NET Framework 4 的 IEnumerable<T> 中，类型 T 是协变的，
    所以可以将 IEnumerable(Of String) 类型的对象分配给 IEnumerable(Of Object) 类型的对象，
    而无需使用任何特殊转换方法。

    可以向协变委托分配相同类型的其他委托，不过要使用派生程度更大的泛型类型参数。
    
    */
    public class Iterator : IEnumerator<SpecialData>
    {
        private int _index = -1;
        private Aggregate aggregate;
        private SpecialData _current;
 
        public Iterator(Aggregate aggregate)
        {
            this.aggregate = aggregate;
        }
        public bool MoveNext()
        {
            if (_index < aggregate.GetSpecialDatas().Count - 1)
            {
                _index++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _index = -1;
        }

        SpecialData IEnumerator<SpecialData>.Current => _current;

        public object Current => aggregate.GetSpecialDatas()[_index];
        public void Dispose()
        {
           
        }
    }
}