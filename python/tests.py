import unittest

from main import Person, CanHaveStudentDiscountSpecification


class TestCanHaveStudentDiscountSpecificationTestCase(unittest.TestCase):
    def test_person_18yo_student_should_have_discount(self):
        person = Person(
            name="John Doe",
            age=18,
            is_student=True
        )

        can_have_discount = CanHaveStudentDiscountSpecification()(person)

        self.assertEqual(can_have_discount, True)

    def test_person_18yo_not_student_should_not_have_discount(self):
        person = Person(
            name="John Doe",
            age=18,
            is_student=False
        )

        can_have_discount = CanHaveStudentDiscountSpecification()(person)

        self.assertEqual(can_have_discount, False)

    def test_person_17yo_student_should_have_discount(self):
        person = Person(
            name="John Doe",
            age=17,
            is_student=True
        )

        can_have_discount = CanHaveStudentDiscountSpecification()(person)

        self.assertEqual(can_have_discount, True)

    def test_person_17yo_not_student_should_have_discount(self):
        person = Person(
            name="John Doe",
            age=17,
            is_student=False
        )

        can_have_discount = CanHaveStudentDiscountSpecification()(person)

        self.assertEqual(can_have_discount, True)


if __name__ == '__main__':
    unittest.main()
