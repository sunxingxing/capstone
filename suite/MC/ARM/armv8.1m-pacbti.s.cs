# CS_ARCH_ARM, CS_MODE_THUMB, None
0xaf,0xf3,0x2d,0x80 = aut r12, lr, sp
0xaf,0xf3,0x0f,0x80 = bti
0xaf,0xf3,0x0f,0x80 = bti
0xaf,0xf3,0x1d,0x80 = pac r12, lr, sp
0xaf,0xf3,0x0d,0x80 = pacbti r12, lr, sp
