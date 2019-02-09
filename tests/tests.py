import unittest
import sys
sys.path.append("..")
from util import get_file_extension

class TestSum(unittest.TestCase):

    def test_sum(self):
        self.assertEqual(sum([1, 2, 3]), 6, "Should be 6")

    def test_extension_getter(self):
        self.assertEqual(get_file_extension('java8', 'java'), '.java', "Should be .java") # for
        self.assertEqual(get_file_extension('python', 'java'), '.py', "Should be .py")

if __name__ == '__main__':
    unittest.main()