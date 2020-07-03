namespace solid{

    public class ColorSpecification : ISpecificaton<Product>{

        private Color color;

        public ColorSpecification(Color color){
            this.color = color;
        }

        bool IsSatisfied (Product t){
            return t.color == color;
        }

        bool ISpecificaton<Product>.IsSatisfied(Product t)
        {
            return t.color == color;
        }
    }

}