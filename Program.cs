using System;

namespace LargestElementInArray {
    class Program {
        private static float[] _numbers = { 11, 15, 16, 79, 100 };

        static void Main(string[] args) => Console.WriteLine(FindMaxIn(_numbers));

        public static float FindMaxIn(float[] numbers) {
            float _largestNumber = 0;
            for (int i = 0; i < _numbers.Length; i++) {
                if (_numbers[i] > _largestNumber) _largestNumber = _numbers[i];
            }
            return _largestNumber;
        }
    }
}
