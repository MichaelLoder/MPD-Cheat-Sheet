namespace BO
{
    public class Charge
    {
        public string Name { get; set; }
        public double Sentence { get; set; }
        public double ArgSentence { get; set; }
        public bool HasArgSentence { get; set; }
        public int ID { get; set; }
        public bool HasAdditionalItems { get; set; }
        public double AdditionalSentence { get; set; }
        public int QtyAmmount { get; set; }
    }
}