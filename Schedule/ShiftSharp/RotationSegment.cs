/*
MIT License

Copyright (c) 2016 Kent Randall

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;

namespace Point85.ShiftSharp.Schedule
{
	/// <summary>
	/// This class represents part of an entire rotation. The segment starts with a shift and includes 
	/// a count of the number of days on followed by the number of days off.
	/// </summary>
	public class RotationSegment : IComparable<RotationSegment>
	{
		/// <summary>
		/// parent rotation
		/// </summary>
		public Rotation Rotation { get; private set; }

		/// <summary>
		/// ordering within the rotation
		/// </summary>
		public int Sequence { get; set; } = 0;

		/// <summary>
		/// shift that starts this segment
		/// </summary>
		public Shift StartingShift { get; set; }

		/// <summary>
		/// number of days on shift
		/// </summary>
		public int DaysOn { get; set; } = 0;

		/// <summary>
		/// number of days off shift
		/// </summary>
		public int DaysOff { get; set; } = 0;

		/// <summary>
		/// Constructor
		/// </summary>
		public RotationSegment()
		{
		}

		internal RotationSegment(Shift startingShift, int daysOn, int daysOff, Rotation rotation)
		{
			this.StartingShift = startingShift;
			this.DaysOn = daysOn;
			this.DaysOff = daysOff;
			this.Rotation = rotation;
		}


		/// <summary>
		/// Compare this rotation segment to
		/// </summary>
		/// <param name="other">Other rotation segment</param>
		/// <returns>-1 if less than, 0 if equal and 1 if greater than</returns>		
		public int CompareTo(RotationSegment other)
		{
			int value = 0;
			if (this.Sequence < other.Sequence)
			{
				value = -1;
			}
			else if (this.Sequence > other.Sequence)
			{
				value = 1;
			}
			return value;
		}
	}
}
