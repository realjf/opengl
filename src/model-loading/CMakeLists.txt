include_directories( ${CMAKE_CURRENT_SOURCE_DIR} )
set(SOURCE_FILES main.cpp ../glad.c)
add_executable(model-loading ${SOURCE_FILES})


target_link_libraries(model-loading
    PUBLIC 
    ${COMMON_LIBS})