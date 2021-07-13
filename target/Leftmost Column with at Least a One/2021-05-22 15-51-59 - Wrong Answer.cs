﻿/*
Status: Wrong Answer
Runtime: N/A
Memory: N/A
URL: http://leetcode.com/submissions/detail/496792468/
Submission DateTime: May 22, 2021 3:51:59 PM
*/
/**
 * // This is BinaryMatrix's API interface.
 * // You should not implement it, or speculate about its implementation
 * class BinaryMatrix {
 *     public int Get(int row, int col) {}
 *     public IList<int> Dimensions() {}
 * }
 */

class Solution
        {
            public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix)
            {
                int rows = binaryMatrix.Dimensions()[0];
                int cols = binaryMatrix.Dimensions()[1];
                int leftMostCol = -1;

                for (int r = 0; r < rows; r++)
                {
                    if (leftMostCol >= 0 && binaryMatrix.Get(r, leftMostCol) == 0) // skip row leftMostCol == 0, becasuse its row leftMostCol is larger then cirrent
                        continue;

                    int rowLeftMostCol = BinSearch(binaryMatrix, r, leftMostCol < 0 ? cols - 1 : leftMostCol - 1);

                    if (rowLeftMostCol >= 0)
                        if (leftMostCol >= 0)
                            leftMostCol = Math.Min(leftMostCol, rowLeftMostCol);
                        else
                            leftMostCol = rowLeftMostCol;
                }

                return leftMostCol;
            }

            private static int BinSearch(BinaryMatrix binaryMatrix, int r, int rightCol)
            {
                int leftCol = 0;
                while (leftCol < rightCol)
                {
                    int mid = (rightCol + leftCol) / 2;
                    if (binaryMatrix.Get(r, mid) == 0)
                    {
                        if (binaryMatrix.Get(r, mid + 1) == 1)
                            return mid + 1;
                        leftCol = mid + 1;
                    }
                    else
                    {
                        if (mid == 0)
                            return 0;
                        if (binaryMatrix.Get(r, mid - 1) == 0)
                            return mid;
                        rightCol = mid;
                    }
                }

                return -1;
            }
        }
