using EvotingApi.Data;
using EvotingApi.Dtos;
using EvotingApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EvotingApi.Repos
{
    public class IntervalRepo
    {
        private readonly EvotingContext context;

        public IntervalRepo(EvotingContext context)
        {
            this.context = context;
        }
        public bool IsVotingAvailable() 
        {
            var date = context.Intervals.FirstOrDefault();
            if (date == null)
                return false;
            var currentDate = DateTime.UtcNow.AddHours(3);
            return date.StartDate <= currentDate && currentDate <= date.EndDate;
        }
        public bool UpdateInterval(IntervalDto interval)
        {
            var date = context.Intervals.FirstOrDefault();
            if (date == null)
            {
                context.Intervals.Add(new Interval
                {
                    EndDate = interval.EndDate,
                    StartDate = interval.StartDate,
                    ID = 0
                });
            }
            else
            {
                date.StartDate = interval.StartDate;
                date.EndDate = interval.EndDate;
                context.Intervals.Update(date);
            }
            return context.SaveChanges() > 0;
        }
    }
}
