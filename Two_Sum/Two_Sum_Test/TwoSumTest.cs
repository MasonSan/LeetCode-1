using Microsoft.VisualStudio.TestTools.UnitTesting;
using Two_Sum;

namespace Two_Sum_Test
{
    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        public void Given_nums_2_7_11_5_target_9_should_return_0_1()
        {
            //arrange
            var target = new Solution();
            var nums = new int[] { 2, 7, 11, 15 };
            var sum_target = 9;
            var expected = new int[] { 0, 1 };

            //action
            var actual = target.TwoSum(nums, sum_target);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given_nums_3_2_4_target_6_should_return_1_2()
        {
            //arrange
            var target = new Solution();
            var nums = new int[] { 3, 2, 4 };
            var sum_target = 6;
            var expected = new int[] { 1, 2 };

            //action
            var actual = target.TwoSum(nums, sum_target);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}