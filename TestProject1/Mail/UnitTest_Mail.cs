using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest_Mail
    {
        // 테스트 카테고리 설정(Jenkins 나 Github에서 카테고리 별 테스트 설정할 때 사용하는 옵션)
        [TestMethod, TestCategory("Program")]
        [DataRow("22", "222", "2222")] // Unit 테스트 함수 설정
        [DataRow("aa", "bb", "cc")] // Unit 테스트 함수 설정
        public void TestofTest(string a, string b, string c)
        {
            try
            {
                System.Diagnostics.Trace.WriteLine("TestofTest : " + a 
                    + " " + b 
                    + " " + c);
                Assert.IsTrue(true);

                // 만약, exception이 발생하지 않으면 error
                //Assert.Fail("exception이 발생하지 않으면 error");
            }
            catch(Exception)
            {

            }
            //catch(Exception)
            //{
            //    //exception이 발생하면 에러다
            //    Assert.Fail("Fail 이다~");
            //}
        }
    }
}
