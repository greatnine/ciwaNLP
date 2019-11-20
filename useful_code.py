
多行变为单行


def become_single_line(multi_line_string):
    if isinstance(multi_line_string, list):
        return ["".join(m for m in multi_line_string)]
    character_map = {
        ord('\n'): None,
        ord('\t'): None,
        ord('\r'): None,
        ord(' '): None}
    result = multi_line_string.translate(character_map)
    return result



if __name__ == '__main__':
    user_input = f"""-


       什么5G？
                 原来是骗人的。

    --
    """
    u = become_single_line(user_input)
    print("-------------------------")
    print(u)
    print("-------------------------")


