#!/usr/bin/sh

BUILD=$(realpath .)/build

./autogen.sh --prefix=$BUILD
./configuire
make
make install
