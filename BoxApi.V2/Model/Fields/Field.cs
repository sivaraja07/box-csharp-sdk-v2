namespace BoxApi.V2.Model.Fields
{
    public interface IField
    {
        string Value { get; }
    }

    public class Field : IField
    {
        public Field(string value)
        {
            Value = value;
        }

        public string Value { get; private set; }
    }
}