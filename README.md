# Address-Rebaser

A rebaser developed for both 3 coding languages, C++, C# and Lua.

Rebasing is the act of creating a process's address space. Rebasing is mostly required for newbies.

# Rebasing Explanation?

For instance, we have an address `0x333F230`, and you want to use Address space layout randomization for it.

First, we will convert `0x333F230` to an integer value, our results then return as `53735984`.

We will now subtract it by 4194304 or 0x400000 but we can't subtract by hex as that makes no sense.

Compilers don't allow to subtract hex, therefore the engine subtracts it via integer and then compiles into hex.

53735984 - 4194304 = `49541680`, which is our integer ASLR'd format. Now we'd convert the int to hex format.

Our final value will be `2F3F230` or in better usage, `0x02F3F230`, and that will be our final result.

# Usage for Rebasing?
