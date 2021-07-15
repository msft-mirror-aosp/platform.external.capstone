# CS_ARCH_X86, CS_MODE_64, CS_OPT_SYNTAX_ATT
0x04,0x00 = addb $0x00, %al
0x04,0x7f = addb $0x7F, %al
0x04,0x80 = addb $0x80, %al
0x04,0xff = addb $0xFF, %al
0x66,0x83,0xc0,0x00 = addw $0x0000, %ax
0x66,0x83,0xc0,0x7f = addw $0x007F, %ax
// 0x66,0x83,0xc0,0x80 = addw $0x80, %ax
// 0x66,0x83,0xc0,0xff = addw $0xFFFF, %ax
0x83,0xc0,0x00 = addl $0x00000000, %eax
0x83,0xc0,0x7f = addl $0x0000007F, %eax
0x05,0x80,0xff,0x00,0x00 = addl $0xFF80, %eax
0x05,0xff,0xff,0x00,0x00 = addl $0xFFFF, %eax
// 0x83,0xc0,0x80 = addl $0xFFFFFF80, %eax
// 0x83,0xc0,0xff = addl $0xFFFFFFFF, %eax
0x48,0x83,0xc0,0x00 = addq $0x0000000000000000, %rax
0x48,0x83,0xc0,0x7f = addq $0x000000000000007F, %rax
0x48,0x83,0xc0,0x80 = addq $0xFFFFFFFFFFFFFF80, %rax
0x48,0x83,0xc0,0xff = addq $0xFFFFFFFFFFFFFFFF, %rax
0x48,0x83,0xc0,0x00 = addq $0x0000000000000000, %rax
0x48,0x05,0x80,0xff,0x00,0x00 = addq $0xFF80, %rax
0x48,0x05,0xff,0xff,0x00,0x00 = addq $0xFFFF, %rax
0x48,0xb8,0x80,0xff,0xff,0xff,0x00,0x00,0x00,0x00 = movabsq $0xFFFFFF80, %rax
0x48,0xb8,0xff,0xff,0xff,0xff,0x00,0x00,0x00,0x00 = movabsq $0xFFFFFFFF, %rax
0x48,0x05,0xff,0xff,0xff,0x7f = addq $0x000000007FFFFFFF, %rax
0x48,0x05,0x00,0x00,0x00,0x80 = addq $0xFFFFFFFF80000000, %rax
0x48,0x05,0x00,0xff,0xff,0xff = addq $0xFFFFFFFFFFFFFF00, %rax
