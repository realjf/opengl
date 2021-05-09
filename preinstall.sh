#!/bin/sh

apt-get install cmake gcc g++ make build-essential -y

apt-get install -y libglew-dev libopengl-dev libx11-dev libxi-dev \
    libxcursor-dev libxrandr-dev libxinerama-dev libglfw3-dev libxxf86vm-dev \
    libgl1-mesa-dev libglu1-mesa-dev libassimp-dev

# yum install glew-devel libXrandr-devel libXi-devel libXcursor-devel libXinerama-devel

# install glfw
git clone https://github.com/glfw/glfw.git
cd glfw
cmake ./
make
sudo make install

# install glad
git clone https://github.com/Dav1dde/glad.git
cd glad
cmake ./
make
sudo cp -a include /usr/local/

# install glm 
git clone https://github.com/g-truc/glm.git
cd glm
cmake ./
make
sudo make install

# download submodule
git submodule update --init --recursive

# git config --global http.proxy http://xxxx

