include_directories( ${CMAKE_CURRENT_SOURCE_DIR} )
set(SOURCE_FILES main.cpp ../glad.c)
# 第三章：模型加载
add_executable(model-loading ${SOURCE_FILES})


target_link_libraries(model-loading
    PUBLIC 
    ${COMMON_LIBS})