namespace Hospital
{
    public interface IPrescribable
    {
        public void PrescribeMedication(string m);

        public void DeprescribeMedication(string m);

        public bool IsPrescribed(string m);

    }
}
