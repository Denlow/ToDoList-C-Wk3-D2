using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ToDoList
{
  public class TaskTest : IDisposable
  {
    public TaskTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=to_do_list;Integrated Security=SSPI;";
    }

    [Fact]
    public void Test_TasksEmptyAtFirst()
    {
      int result = Task.GetAll().Count;
      Assert.Equal(0, result);
    }
  }
}
