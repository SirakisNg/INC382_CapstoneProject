using System;


namespace MyDog.Data
{
    public class MyDbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext>options): base(options)
        {

        }
    }
}
