using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobBoardVariable
  {
    private string _jobPostTitle;
    private string _jobPostDescription;
    private static List<JobBoardVariable> _jobList = new List<JobBoardVariable> {};

    public JobBoardVariable(string jobPostTitle, string jobPostDescription)
    {
      _jobPostTitle = jobPostTitle;
      _jobPostDescription = jobPostDescription;
    }
    public string GetJobPostTitle()
    {
      return _jobPostTitle;
    }
    public string GetJobPostDescription()
    {
      return _jobPostDescription;
    }
    public static List<JobBoardVariable> GetAll()
    {
      return _jobList;
    }
    public void Save()
    {
      _jobList.Add(this);
    }
  }
}
