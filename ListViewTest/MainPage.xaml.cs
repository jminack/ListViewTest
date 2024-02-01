namespace ListViewTest
{
    public partial class MainPage : ContentPage
    {
        class TestItem
        {
            public string? TimeStamp { get; set; }
            public string? Type { get; set; }
            public string? Channel { get; set; }
            public string? Value1 { get; set; }
            public string? Value2 { get; set; }
        }

        List<TestItem> testItems = new List<TestItem>
            {
                new TestItem { TimeStamp = "2019-01-01 00:00:00", Type = "Type1", Channel = "Channel1", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:01", Type = "Type2", Channel = "Channel2", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:02", Type = "Type3", Channel = "Channel3", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:03", Type = "Type4", Channel = "Channel4", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:04", Type = "Type5", Channel = "Channel5", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:05", Type = "Type6", Channel = "Channel6", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:06", Type = "Type7", Channel = "Channel7", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:07", Type = "Type8", Channel = "Channel8", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:08", Type = "Type9", Channel = "Channel9", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:00", Type = "Type1", Channel = "Channel1", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:01", Type = "Type2", Channel = "Channel2", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:02", Type = "Type3", Channel = "Channel3", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:03", Type = "Type4", Channel = "Channel4", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:04", Type = "Type5", Channel = "Channel5", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:05", Type = "Type6", Channel = "Channel6", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:06", Type = "Type7", Channel = "Channel7", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:07", Type = "Type8", Channel = "Channel8", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:08", Type = "Type9", Channel = "Channel9", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:00", Type = "Type1", Channel = "Channel1", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:01", Type = "Type2", Channel = "Channel2", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:02", Type = "Type3", Channel = "Channel3", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:03", Type = "Type4", Channel = "Channel4", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:04", Type = "Type5", Channel = "Channel5", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:05", Type = "Type6", Channel = "Channel6", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:06", Type = "Type7", Channel = "Channel7", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:07", Type = "Type8", Channel = "Channel8", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:08", Type = "Type9", Channel = "Channel9", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:00", Type = "Type1", Channel = "Channel1", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:01", Type = "Type2", Channel = "Channel2", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:02", Type = "Type3", Channel = "Channel3", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:03", Type = "Type4", Channel = "Channel4", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:04", Type = "Type5", Channel = "Channel5", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:05", Type = "Type6", Channel = "Channel6", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:06", Type = "Type7", Channel = "Channel7", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:07", Type = "Type8", Channel = "Channel8", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:08", Type = "Type9", Channel = "Channel9", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:00", Type = "Type1", Channel = "Channel1", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:01", Type = "Type2", Channel = "Channel2", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:02", Type = "Type3", Channel = "Channel3", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:03", Type = "Type4", Channel = "Channel4", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:04", Type = "Type5", Channel = "Channel5", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:05", Type = "Type6", Channel = "Channel6", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:06", Type = "Type7", Channel = "Channel7", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:07", Type = "Type8", Channel = "Channel8", Value1 = "Value1", Value2 = "Value2" },
                new TestItem { TimeStamp = "2019-01-01 00:00:08", Type = "Type9", Channel = "Channel9", Value1 = "Value1", Value2 = "Value2" },
            };  

        public MainPage()
        {
            InitializeComponent();

            test_LV.ItemsSource = testItems;

        }
    }

}
