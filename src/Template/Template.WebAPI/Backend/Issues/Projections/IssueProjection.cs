﻿using System;
using Backend.Contracts.Issues.Events;
using Marten.Events.Projections;

namespace Backend.Issues.Projections
{
    internal class IssueProjection : ViewProjection<Contracts.Issues.Views.Issue, Guid>
    {
        public IssueProjection()
        {
            ProjectEvent<IssueCreated>(ev => ev.IssueId, (item, @event) => item.Apply(@event));
        }

        private void Apply(Contracts.Issues.Views.Issue item, IssueCreated @event)
        {
        }
    }
}