/**
 * 
 */
package me.sample.alohachina.business.service;

import java.io.Serializable;

import org.springframework.data.domain.Page;

/**
 * @author jianwang
 *
 */
public interface BaseService<TItem extends Serializable> {

	Page<TItem> getAll(int pageIndex, int pageSize);

    long count();

    TItem findByKey(TItem item);

    TItem addItem(TItem item);

    TItem updateItem(TItem item);

    void deleteItem(TItem item);
}
