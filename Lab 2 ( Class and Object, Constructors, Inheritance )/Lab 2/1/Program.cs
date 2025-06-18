//Write a program to create a class named Candidate with ID, Name, Age,
//Weight and Height as data members & also create a member functions like
//GetCandidateDetails() and DisplayCandidateDetails().


using _1;

class Program
{
    static void Main(string[] args)
    {
       
        Candidate candidate = new();
        
        candidate.GetCandidateDetails();
        
        candidate.DisplayCandidateDetails();
    }
}
