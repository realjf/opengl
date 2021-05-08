cmake_minimum_required(VERSION 3.8 FATAL_ERROR)

project(opengl)

set(CMAKE_CXX_STANDARD 11)
set(CMAKE_CXX_EXTENSIONS OFF)
set(CMAKE_CXX_STANDARD_REQUIRED ON)
set(CMAKE_C_STANDARD 99)

# glfw header files
set( GLFW_INCLUDE_DIR ${opengl_SOURCE_DIR}/deps/glfw/include )
set( GLFW_DEPS_INCLUDE_DIR ${opengl_SOURCE_DIR}/deps/glfw/deps )
# glad header files
set( GLAD_INCLUDE_DIR ${opengl_SOURCE_DIR}/deps/glad/include )


list( APPEND opengl_INCLUDE ${GLFW_INCLUDE_DIR})
list( APPEND opengl_INCLUDE ${GLFW_DEPS_INCLUDE_DIR})
list( APPEND opengl_INCLUDE ${GLAD_INCLUDE_DIR})

# legacy
# find_package( OpenGL REQUIRED )

if(WIN32)
    if("${MSVC_C_ARCHITECTURE_ID}" STREQUAL "X86")
      set(ARCH "i686")
      link_directories(${opengl_SOURCE_DIR}/deps/windows/x86/glfw/lib-vc2017)
      set( GLFW_INCLUDE_DIR ${opengl_SOURCE_DIR}/deps/windows/x86/glfw/include )
    elseif("${MSVC_C_ARCHITECTURE_ID}" STREQUAL "x64")
      set(ARCH "x86_64")
      link_directories(${opengl_SOURCE_DIR}/deps/windows/x64/glfw/lib-vc2017)
      set( GLFW_INCLUDE_DIR ${opengl_SOURCE_DIR}/deps/windows/x64/glfw/include )
    else()
      link_directories(${opengl_SOURCE_DIR}/deps/windows/x64/glfw/lib-vc2017)
      set( GLFW_INCLUDE_DIR ${opengl_SOURCE_DIR}/deps/windows/x64/glfw/include )
    endif()
    
    list( APPEND opengl_INCLUDE ${GLFW_INCLUDE_DIR})
    set(COMMON_LIBS optimized glfw3 opengl32 ${GLFW_LIBRARIES} ${OPENGL_LIBRARIES})
elseif (UNIX)
    set(COMMON_LIBS glfw X11 GL GLEW Xrandr Xi Xxf86vm Xcursor Xinerama pthread GLU dl GLU assimp)
else()
    set(COMMON_LIBS optimized glfw3 opengl32 ${GLFW_LIBRARIES} ${OPENGL_LIBRARIES})
endif()


if(CMAKE_SIZEOF_VOID_P EQUAL 8)
    message("architecture: 64-bit")
else()
    message("architecture: 32-bit")
endif()


include_directories( ${opengl_INCLUDE} )

# defines targets and sources
add_subdirectory(src)

# enable testing and define tests
# enable_testing()
# add_subdirectory(tests)

