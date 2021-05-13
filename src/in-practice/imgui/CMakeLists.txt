set(SOURCE_FILES main.cpp ../../glad.c)
add_executable(imgui ${SOURCE_FILES})

# add_subdirectory(renderer)

target_link_libraries(imgui 
    PUBLIC 
    ${COMMON_LIBS})
