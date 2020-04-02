Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports ClassLibrary1

<TestClass()> Public Class UnitTest1

	<TestMethod()> Public Sub TestMethod1()

		Dim cls As New Class1
		Dim big As Integer

		big = cls.BigOfTwo(5, 2)

		Assert.AreEqual(big, 5)

	End Sub


	<TestMethod()> Public Sub TestMethod2()

		Dim cls As New Class1
		Dim big As Integer

		big = cls.BigOfTwo(1, 2)

		Assert.AreEqual(big, 2)

	End Sub

End Class