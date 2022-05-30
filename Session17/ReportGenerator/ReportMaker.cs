namespace ReportGenerator
{
    public class ReportMaker
    {
        private readonly IOutputGenerator _outputGenerator;
        public ReportMaker(IOutputGenerator outputGenerator)
        {
            _outputGenerator = outputGenerator;
        }

        public byte[] Generate(string xml)
        {
            //.....
            //if (...)
            _outputGenerator.AddTitle("Test");
            //....
            //....
            _outputGenerator.Row("Row 1");
            _outputGenerator.Row("Row 2");

            return null;
        }
    }
}