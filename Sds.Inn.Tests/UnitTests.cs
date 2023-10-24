using Sds.Inn.DoNotChange;

namespace Sds.Inn.Tests
{
    public class UnitTests
    {
        private static ItemProvider itemProvider = new ItemProvider();
        private static ItemRuleProvider itemRuleProvider = new ItemRuleProvider();
        private static Inventory inventory = new Inventory(itemProvider, itemRuleProvider);

        [Fact]
        public void UpdateQualityTest()
        {
            var items = itemProvider.GetItems().ToArray();
            inventory.UpdateQuality();

            Assert.Equal(19, items[0].Quality);
            Assert.Equal(9, items[0].SellIn);

            Assert.Equal(1, items[1].Quality);
            Assert.Equal(1, items[1].SellIn);

            Assert.Equal(6, items[2].Quality);
            Assert.Equal(4, items[2].SellIn);

            Assert.Equal(80, items[3].Quality);
            Assert.Equal(0, items[3].SellIn);

            Assert.Equal(21, items[4].Quality);
            Assert.Equal(14, items[4].SellIn);

            Assert.Equal(2, items[5].SellIn);
            Assert.Equal(4, items[5].Quality);
        }

        //[Fact]
        //public void UpdateQualityTestAfter5Days()
        //{
        //    var items = itemProvider.GetItems().ToArray();
        //    inventory.UpdateQuality();

        //    Assert.Equal(19, items[0].Quality);
        //    Assert.Equal(9, items[0].SellIn);

        //    Assert.Equal(1, items[1].Quality);
        //    Assert.Equal(1, items[1].SellIn);

        //    Assert.Equal(6, items[2].Quality);
        //    Assert.Equal(4, items[2].SellIn);

        //    Assert.Equal(80, items[3].Quality);
        //    Assert.Equal(0, items[3].SellIn);

        //    Assert.Equal(21, items[4].Quality);
        //    Assert.Equal(14, items[4].SellIn);

        //    Assert.Equal(2, items[5].SellIn);
        //    Assert.Equal(4, items[5].Quality);
        //}
    }
}