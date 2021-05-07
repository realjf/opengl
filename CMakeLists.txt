cmake_minimum_required(VERSION 3.20 FATAL_ERROR)

project(opengl LANGUAGES CXX)

set(CMAKE_CXX_STANDARD 11)
set(CMAKE_CXX_EXTENSIONS OFF)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

# glfw header files
set( GLFW_INCLUDE_DIR ${opengl_SOURCE_DIR}/deps/glfw/include )
# glad header files
set( GLAD_INCLUDE_DIR ${opengl_SOURCE_DIR}/deps/glad/include )

list( APPEND opengl_INCLUDE ${GLFW_INCLUDE_DIR})
list( APPEND opengl_INCLUDE ${GLAD_INCLUDE_DIR})


find_package( OpenGL REQUIRED )

if(WIN32)
    set(COMMON_LIBS optimized glfw3 debug glfw3_d ${GLFW_LIBRARIES} ${OPENGL_LIBRARIES})
elseif (UNIX)
    set(COMMON_LIBS glfw3 X11 GL GLEW)
else()
    set(COMMON_LIBS)
endif()

include_directories( ${opengl_INCLUDE} )

# defines targets and sources
add_subdirectory(src)

# enable testing and define tests
# enable_testing()
# add_subdirectory(tests)

