using BlogLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLogic
{
    public  class VotingManager
    {
        public void AddMaleVote()
        {
            using (BlogContext db = new BlogContext())
            {
                db.Voting.First().Male++;
                db.SaveChanges();
            }
        }

        public void AddFemaleVote()
        {
            using (BlogContext db = new BlogContext())
            {
                db.Voting.First().Female++;
                db.SaveChanges();
            }
        }

        public Voting GetData()
        {
            Voting answer = new Voting();
            using (BlogContext db = new BlogContext())
            {
                answer = db.Voting.First();
            }
            return answer;
        }
    }
}
