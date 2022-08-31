from dataclasses import dataclass

from specifications import BaseSpecification


@dataclass(frozen=True)
class Person:
    name: str
    age: int
    is_student: bool


@dataclass
class HasLegalAgeSpecification(BaseSpecification):

    def is_satisfied_by(self, candidate: Person) -> bool:
        return candidate.age >= 18

@dataclass
class IsStudentSpecification(BaseSpecification):

    def is_satisfied_by(self, candidate: Person) -> bool:
        return candidate.is_student

@dataclass
class CanHaveStudentDiscountSpecification(BaseSpecification):

    def is_satisfied_by(self, candidate: Person) -> bool:
        return (-HasLegalAgeSpecification() | IsStudentSpecification()).is_satisfied_by(candidate)


if __name__ == '__main__':
    person = Person(
        name="John Doe",
        age=19,
        is_student=False
    )

    can_have_discount = CanHaveStudentDiscountSpecification().is_satisfied_by(person)
    print(can_have_discount)
