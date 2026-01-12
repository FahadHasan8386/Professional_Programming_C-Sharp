using System.Data.SqlClient;

public class StudentAdoService
{
    string cs = "Server=.;Database=StudentDB;Trusted_Connection=True;";

    public async Task<List<Student>> GetStudents()
    {
        List<Student> list = new List<Student>();

        SqlConnection con = new SqlConnection(cs);
        await con.OpenAsync();

        SqlCommand cmd = new SqlCommand(
            "SELECT * FROM Students", con);

        SqlDataReader rd = await cmd.ExecuteReaderAsync();

        while (await rd.ReadAsync())
        {
            list.Add(new Student
            {
                Id = (int)rd["Id"],
                Name = rd["Name"].ToString(),
                Age = (int)rd["Age"]
            });
        }

        con.Close();
        return list;
    }
}
