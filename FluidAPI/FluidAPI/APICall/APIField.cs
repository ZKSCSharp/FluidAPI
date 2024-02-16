namespace FluidAPI.APICall
{
    public class APIField
    {
        private string name;
        private dynamic value;

        public APIField(string name, dynamic val)
        {
            this.name = name;
            this.value = val;
        }

        public string Name
        { get { return this.name; } }
        public dynamic Value
        { get { return this.value; } }
    }
}
