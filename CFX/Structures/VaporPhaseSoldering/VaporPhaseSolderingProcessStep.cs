﻿/*
ASCII Representation of the Process Steps:

+-------------------+      +-------------------+      +-------------------+      +-------------------+
| Step Number: 1    | ---> | Step Number: 2    | ---> | Step Number: 3    | ---> | Step Number: 4    |
| Step ID: 4        |      | Step ID: 3        |      | Step ID: 2        |      | Step ID: 1        |
|                   |      |                   |      |                   |      |                   |
+-------------------+      +-------------------+      +-------------------+      +-------------------+

Explanation:
- StepNumber: Represents the actual execution order (1, 2, 3, 4).
- StepId: A unique identifier for each step (4, 3, 2, 1), which may differ from the execution order.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.VaporPhaseSoldering
{
    /// <summary>
    /// Vapor Phase Soldering Process Step
    /// <para>** NOTE: ADDED in CFX 2.0 **</para>
    /// </summary>
    [CFX.Utilities.CreatedVersion("2.0")]
    public class VaporPhaseSolderingProcessStep
    {
        public int StepNumber // 1, 2, 3, 4 - Actual execution order
        {
            get;
            set;
        }

        public string StepId // 4, 3, 1, 2 - Unique identifier for each step
        {
            get;
            set;
        }

        public VaporPhaseSolderingProcessStepType StepType
        {
            get;
            set;
        }

        public VaporPhaseSolderingProcessStepState StepState
        {
            get;
            set;
        }
    }
}
