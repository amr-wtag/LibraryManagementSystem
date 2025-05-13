namespace LibraryManagementSystem.Winforms.helpers
{
    [Serializable]
    public class DropDownOption
    {
        public string Label { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Label;
        }
    }
}

