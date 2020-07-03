using System.Collections.Generic;

namespace solid{  
    public interface IFilter<T>{
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecificaton<T> spec);
    }

}