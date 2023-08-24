using System;
using System.Collections.Generic;
using System.Text;

namespace PieceOfSalami
{
    class NumericValueSplit<T>
    {
        public T NumericValueNotSplit { get; }
        public int[] NumericValueSplitIntoArray { get; }

        public NumericValueSplit(T integerToSplit)
        {
            this.NumericValueNotSplit = integerToSplit;
            NumericValueSplitIntoArray = SplitValueIntoArrayOfNumbers();
        }

        private int[] SplitValueIntoArrayOfNumbers()
        {
            char[] charOfNumbers = NumericValueNotSplit.ToString().ToCharArray();
            int[] integersSplitToArray = new int[charOfNumbers.Length];
            for (int i = 0; i < charOfNumbers.Length; i++)
            {
                integersSplitToArray[i] = (int)Char.GetNumericValue(charOfNumbers[i]);
            }
            return integersSplitToArray;
        }

        public int GetSumOfNumericValueNumbers()
        {
            int sum = 0;
            foreach (var item in NumericValueSplitIntoArray)
            {
                sum += item;
            }
            return sum;
        }

        public int GetNumericValueLastNumber()
        {
            return NumericValueSplitIntoArray[NumericValueSplitIntoArray.Length - 1];
        }

        public bool isSumNumbersMultipleToLastNumber()
        {
            bool multiplicity;

            if(GetNumericValueLastNumber() == 0)
            {
                multiplicity = true;
            }
            else
            {
                if(GetSumOfNumericValueNumbers() % GetNumericValueLastNumber() == 0)
                {
                    multiplicity = true;
                }
                else
                {
                    multiplicity = false;
                }
            }

            return multiplicity;
        }
    }
}
