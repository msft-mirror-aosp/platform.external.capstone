# CS_ARCH_PPC, CS_MODE_BIG_ENDIAN, CS_OPT_SYNTAX_NOREGNAME
0x7c,0x02,0x1f,0xac = icbi 2, 3
0x7c,0x02,0x1a,0x2c = dcbt 2, 3
0x7c,0x02,0x19,0xec = dcbtst 2, 3
0x7c,0x02,0x1f,0xec = dcbz 2, 3
0x7c,0x02,0x18,0x6c = dcbst 2, 3
0x4c,0x00,0x01,0x2c = isync 
0x7c,0x43,0x21,0x2d = stwcx. 2, 3, 4
0x7c,0x43,0x21,0xad = stdcx. 2, 3, 4
// 0x7c,0x40,0x04,0xac = sync 2
0x7c,0x00,0x06,0xac = eieio 
// 0x7c,0x40,0x00,0x7c = wait 2
0x7c,0x02,0x18,0xac = dcbf 2, 3
0x7c,0x43,0x20,0x28 = lwarx 2, 3, 4
0x7c,0x43,0x20,0xa8 = ldarx 2, 3, 4
0x7c,0x00,0x04,0xac = sync 0
0x7c,0x00,0x04,0xac = sync 0
// 0x7c,0x20,0x04,0xac = sync 1
// 0x7c,0x40,0x04,0xac = sync 2
// 0x7c,0x00,0x00,0x7c = wait 0
// 0x7c,0x20,0x00,0x7c = wait 1
// 0x7c,0x40,0x00,0x7c = wait 2
0x7c,0x5b,0x1a,0xe6 = mftb 2, 123
0x7c,0x4c,0x42,0xe6 = mftb 2, 268
// 0x7c,0x4d,0x42,0xe6 = mftb 2, 269
