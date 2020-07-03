using System.Collections.Generic;


namespace solid { 
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecificaton<Product> spec)
        {
            foreach(var i in items){
                if(spec.IsSatisfied(i)){
                    yield return i;
                }
            }
        }
    }
}