﻿using BoDi;
using Zukini.Steps;

namespace Zukini.API.Steps
{
    public abstract class ApiSteps : ApiSteps<StepsContext>
    {
        public ApiSteps(IObjectContainer objectContainer) : base(objectContainer)
        {
            Context = new StepsContext(objectContainer);
        }

        /// <summary>
        /// Returns the registered PropertyBucket used for remembering properties
        /// between steps.
        /// </summary>
        protected PropertyBucket PropertyBucket
        {
            get
            {
                return Context.PropertyBucket;
            }
        }

        /// <summary>
        /// Returns the uniquely generated TestId associated with this test.
        /// This is just a handy property to get the testid without 
        /// </summary>
        protected string TestId
        {
            get
            {
                return Context.PropertyBucket.TestId;
            }
        }
    }
}
