def check_positive_and_rounding(rounding=2):
    def check_positive(func):
        def wrapper(*args, **kwargs):
            for arg in args:
                if isinstance(arg, (int, float)) and arg < 0:
                    raise ValueError("Không chấp nhận số âm, hoặc không phải giá trị số")
            return round(func(*args, **kwargs), rounding)
        return wrapper
    return check_positive
 
@check_positive_and_rounding(3)
def rec_area(length, width):
    return length * width
 
@check_positive_and_rounding(rounding=4)
def squ_area(side):
    return side * side
 
@check_positive_and_rounding(5)
def cir_area(radius):
    import math
    return math.pi * radius * radius
 
print(cir_area(5.123456))
print(squ_area(4.231456))
print(rec_area(3.11113333, 6.23489))