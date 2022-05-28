local address = 0x333F230--does roblox read hex? if do, thats kinda gay.
local rebaser = 0x400000

function magic()
  local subtruct = address - rebaser --subtract
  print("uhm here u go"..subtruct)--results
end

magic()--run
